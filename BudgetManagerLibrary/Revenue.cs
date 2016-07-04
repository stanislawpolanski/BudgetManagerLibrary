using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	class Revenue : BudgetPosition
	{
		public Revenue()
		{
			base.Factor = 1;
		}
	}
}
