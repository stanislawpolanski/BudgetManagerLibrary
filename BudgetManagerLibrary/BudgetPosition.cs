using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	class BudgetPosition : IComparable
	{
		public float AbsoluteValue;
		public float Factor;
		public float Value
		{
			get
			{
				return Factor * AbsoluteValue;
			}
			private set { }
		}
		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}
	}
}
