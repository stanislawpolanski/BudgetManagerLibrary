using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetManagerLibrary
{
	public class BudgetPositionsList : List<BudgetPosition>
	{
		internal float Balance
		{
			get
			{
				return this.Sum(bpl => bpl.Value);
			}
		}
	}
}