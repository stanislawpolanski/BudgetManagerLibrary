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
		public bool AddRow(BudgetItem bp)
		{
			//TODO WRITING NEW ITEM TO A FILE
			throw new NotImplementedException();
		}

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
			try
			{
				Budget b = new Budget();
				DataFile = XDocument.Load(accessString);
				XElement xBudgetItems = DataFile.Element("Budget");

				foreach (XElement item in xBudgetItems.Elements())
				{
					BudgetItem bp = new BudgetItem();

					//processing basic data
					bp.AbsoluteValue = Convert.ToSingle(item.Element("AbsoluteValue").Value, CultureInfo.InvariantCulture);
					bp.BookingDate = Convert.ToDateTime(item.Element("BookingDateTime").Value);
					if (item.Element("ItemType").Value == "Revenue")
						bp.ValueFactor = 1;
					else if (item.Element("ItemType").Value == "Expense")
						bp.ValueFactor = -1;
					else
						throw new Exception("Unknown item type.");

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
			Console.WriteLine("Writing to a file fired with value of: {0}", iae.newBudgetItem.AbsoluteValue);
			//TODO WRITING ITEM TO XML FILE
			
		}
	}
}
