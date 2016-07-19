using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	public class ItemAddedEventArgs : EventArgs
	{
		public BudgetItem newBudgetItem = null;

		public ItemAddedEventArgs(BudgetItem bi)
		{
			this.newBudgetItem = bi;
		}
	}
}
