using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BudgetManagerLibrary.Models
{
	/// <summary>
	/// Reads and writes data into XML file.
	/// </summary>
	public class XMLDataModel : IDataModel
	{
		private XDocument DataFile = null;
		private Budget LoadedBudget = null;
		private string AccessString = null;

		/// <summary>
		/// Returns loaded budget. If budget is not loaded throws NullReferenceException.
		/// </summary>
		/// <returns>Budget class.</returns>
		public Budget GetBudget()
		{
			//check if budget is loaded
			if (DataFile == null)
				throw new NullReferenceException("Data file not loaded!");
			if (LoadedBudget == null)
				throw new NullReferenceException("Budget not processed even though file loaded!");

			//if ok, then subscribe to budget
			this.SubscribeToBudget(LoadedBudget);

			return LoadedBudget;
		}

		/// <summary>
		/// Load budget from a file.
		/// </summary>
		/// <param name="accessString">Path to XML budget file.</param>
		/// <returns>True if budget loaded succesfully, false otherwise.</returns>
		public bool LoadBudget(string accessString)
		{
			this.AccessString = accessString;
			try
			{
				//create new empty budget to fill it with items from a file
				Budget b = new Budget();

				//load xml file
				DataFile = XDocument.Load(this.AccessString);
				XElement xBudgetItems = DataFile.Element("Budget");

				//loop XML file to process every single budget item
				foreach (XElement item in xBudgetItems.Elements())
				{
					Item bp = new Item();

					//processing value and booking date
					bp.AbsoluteValue = Convert.ToSingle(item.Element("AbsoluteValue").Value, CultureInfo.InvariantCulture);
					bp.BookingDate = Convert.ToDateTime(item.Element("BookingDateTime").Value);

					//read item type
					Item.ItemType bitype;
					if (!Enum.TryParse<Item.ItemType>(item.Element("ItemType").Value, out bitype))
						throw new Exception("Unknown item type.");
					bp.Type = bitype;

					//processing receipt info
					XElement xReceipt = item.Element("Receipt");
					bp.BillingDate = Convert.ToDateTime(xReceipt.Element("BillingDateTime").Value);
					bp.ReceiptName = xReceipt.Element("Name").Value;

					//add 
					b.LoadItem(bp);
				}

				//write processed budget class to model's variable
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

		/// <summary>
		/// Subscribe to budget changes.
		/// </summary>
		/// <param name="b">Budget class.</param>
		public void SubscribeToBudget(Budget b)
		{
			b.ItemAddedEvent += new Budget.ItemAddedHandler(WriteNewItem);
		}

		/// <summary>
		/// Write new item to budget.
		/// </summary>
		/// <param name="b">Budget class.</param>
		/// <param name="e">Event args.</param>
		private void WriteNewItem(Budget b, EventArgs e)
		{
			//Cast EventArgs to ItemAddedEventArgs
			ItemAddedEventArgs iae = e as ItemAddedEventArgs;
			//prepare new item
			Item bi = iae.newBudgetItem;
			
			//add new item to an xml file
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

			//write new item to a file and reload the file
			DataFile.Save(AccessString);
			this.LoadBudget(AccessString);
		}
	}
}
