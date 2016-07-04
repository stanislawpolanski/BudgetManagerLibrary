using System;
using System.Collections.Generic;

namespace BudgetManagerLibrary
{
	class BudgetPositionsList : List<BudgetPosition>
	{
		internal float? Balance;
		public float GetBalance()
		{
			if (this.Balance == null)
				this.ComputeBalance();
			return (float)this.Balance;
		}

		internal void ComputeBalance()
		{
			this.ForEach(delegate (BudgetPosition bp)
			{
				Balance += bp.Value;
			}
			);
		}
	}
}