using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BudgetManagerLibrary.Models
{
	public class XMLDataModel : IDataModel
	{
		private XDocument DataFile = null;
		private Budget LoadedBudget = null;
		private string AccessString = null;

		public Budget GetBudget()
		{
			//check if budget is loaded
			if (DataFile == null)
				throw new NullReferenceException("Data file not loaded!");
			if (LoadedBudget == null)
				throw new NullReferenceException("Budget not processed even though file loaded!");

			this.SubscribeToBudget(LoadedBudget);

			return LoadedBudget;
		}

		public bool LoadBudget(string accessString)
		{
			this.AccessString = accessString;
			try
			{
				Budget b = new Budget();
				DataFile = XDocument.Load(this.AccessString);
				XElement xBudgetItems = DataFile.Element("Budget");

				foreach (XElement item in xBudgetItems.Elements())
				{
					BudgetItem bp = new BudgetItem();

					//processing basic data
					bp.AbsoluteValue = Convert.ToSingle(item.Element("AbsoluteValue").Value, CultureInfo.InvariantCulture);
					bp.BookingDate = Convert.ToDateTime(item.Element("BookingDateTime").Value);


					BudgetItem.ItemType bitype;
					if (!Enum.TryParse<BudgetItem.ItemType>(item.Element("ItemType").Value, out bitype))
						throw new Exception("Unknown item type.");
					bp.Type = bitype;

					//processing receipt info
					XElement xReceipt = item.Element("Receipt");
					bp.BillingDate = Convert.ToDateTime(xReceipt.Element("BillingDateTime").Value);
					bp.ReceiptName = xReceipt.Element("Name").Value;

					b.LoadItem(bp);
				}

				LoadedBudget = b;
			}
			catch(Exception)
			{
				return false;
				throw;
			}
			//TODO validation with xml schema
			

			return true;
		}

		public void SubscribeToBudget(Budget b)
		{
			b.ItemAddedEvent += new Budget.ItemAddedHandler(WriteNewItem);
		}

		private void WriteNewItem(Budget b, EventArgs e)
		{
			ItemAddedEventArgs iae = e as ItemAddedEventArgs;
			BudgetItem bi = iae.newBudgetItem;
			
			DataFile.Element("Budget").Add
			(new XElement("BudgetItem",
				new XElement("AbsoluteValue", bi.AbsoluteValue),
				new XElement("BookingDateTime", bi.BookingDate),
				new XElement("ItemType", bi.Type),
				new XElement("Receipt",
						new XElement("BillingDateTime", bi.BillingDate),
						new XElement("Name", bi.ReceiptName)
					)
				)
			);
			DataFile.Save(AccessString);
			this.LoadBudget(AccessString);
		}
	}
}
