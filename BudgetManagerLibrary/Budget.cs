using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	/// <summary>
	/// Budget class represents a budget. It holds collection of budget positions and gets the balance from the collection.
	/// </summary>
	public class Budget
	{
		public event ItemAddedHandler ItemAddedEvent;
		public delegate void ItemAddedHandler(Budget b, EventArgs e);
		
		/// <summary>
		/// Collection of budget positions like revenues, expenses etc.
		/// </summary>
		public BudgetItemsList ItemsList
		{
			get;
			private set;

		}

		public Budget()
		{
			ItemsList = new BudgetItemsList();
		}

		/// <summary>
		/// Adds a position into the collection.
		/// </summary>
		/// <param name="bi">Budget position.</param>
		public void LoadItem(BudgetItem bi)
		{
			this.ItemsList.Add(bi);
		}

		public void LoadItem(BudgetItemsList bil)
		{
			this.ItemsList = bil;
		}

		public void AddNewItem(BudgetItem nbi)
		{
			this.ItemsList.Add(nbi);
			ItemAddedEventArgs e = new ItemAddedEventArgs(nbi);
			if (ItemAddedEvent != null)
				ItemAddedEvent(this, e);
		}

		/// <summary>
		/// Gets the balance from the collection.
		/// </summary>
		/// <returns>Balance</returns>
		public float GetBalance()
		{
			return ItemsList.GetBalance;
		}

		public DataTable ToDataTable()
		{
			throw new NotImplementedException();
		}
	}
}
