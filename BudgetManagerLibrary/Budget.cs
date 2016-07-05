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

		public void AddPosition(BudgetPosition bp)
		{
			this.BPL.Add(bp);
		}

		public float GetBalance()
		{
			return BPL.Balance;
		}
	}
}
