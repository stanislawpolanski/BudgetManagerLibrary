using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	public class Budget
	{
		public BudgetPositionsList BPL = new BudgetPositionsList();

		public float GetBalance()
		{
			return BPL.Balance;
		}
	}
}
