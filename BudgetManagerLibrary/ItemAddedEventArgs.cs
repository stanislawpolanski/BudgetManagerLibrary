using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	/// <summary>
	/// When the collection gets new item it should fire this event.
	/// </summary>
	public class ItemAddedEventArgs : EventArgs
	{
		public Item newBudgetItem = null;

		/// <summary>
		/// Creates an instance of the class.
		/// </summary>
		/// <param name="bi">Item that caused the event.</param>
		public ItemAddedEventArgs(Item bi)
		{
			this.newBudgetItem = bi;
		}
	}
}
