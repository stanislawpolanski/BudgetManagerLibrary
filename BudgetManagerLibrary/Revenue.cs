using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	public class Revenue : BudgetPosition
	{
		public Revenue()
		{
			base.ValueFactor = 1;
		}
	}
}
