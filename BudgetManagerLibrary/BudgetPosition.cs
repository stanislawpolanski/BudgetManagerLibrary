using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	/// <summary>
	/// Holds an info about value of budget position.
	/// </summary>
	public class BudgetPosition : IComparable
	{
		public uint Id;
		public Receipt Rcp;
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
		/// <summary>
		/// Compares to another budget position using Value and Factor.
		/// </summary>
		/// <param name="obj">Another BudgetPosition</param>
		/// <returns>Returns 1 if this one is higher, 0 if they're equal and -1 if this one is lower.</returns>
		public int CompareTo(object obj)
		{
			//Convert input to Budget posistion
			BudgetPosition otherBudgetPosition = obj as BudgetPosition;

			//If conversion is succesful then compare, throw ArgumentException otherwise
			if (otherBudgetPosition != null)
			{
				if (this.Value > otherBudgetPosition.Value)
					return 1;
				else if (this.Value == otherBudgetPosition.Value)
					return 0;
				else
					return -1;
			}
			else
				throw new ArgumentException("Object is not a BudgetPosition");
		}
	}
}
