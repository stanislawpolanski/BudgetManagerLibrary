using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	class Budget
	{
		public BudgetPositionsList BPL = new BudgetPositionsList();

		private float GetBalance()
		{
			return BPL.GetBalance();
		}
	}
}
