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
		public ItemsList ItemsList
		{
			get;
			private set;

		}

		public Budget()
		{
			ItemsList = new ItemsList();
		}

		/// <summary>
		/// Loads an item into the collection.
		/// </summary>
		/// <param name="bi">Budget position.</param>
		public void LoadItem(Item bi)
		{
			this.ItemsList.Add(bi);
		}

		/// <summary>
		/// Loads collection of items into the class collection.
		/// </summary>
		/// <param name="bil">Collection of items.</param>
		public void LoadItem(ItemsList bil)
		{
			this.ItemsList = bil;
		}

		/// <summary>
		/// Adds a brand new item to the collection. Then fires the event. The event tells the subscribers that there's new item in the collection.
		/// </summary>
		/// <param name="nbi">New budget item.</param>
		public void AddNewItem(Item nbi)
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
	}
}
