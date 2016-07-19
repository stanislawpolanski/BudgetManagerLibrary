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
	public class BudgetItem : IComparable
	{
		public int Id;
		public DateTime BookingDate;
		public DateTime BillingDate;
		public string ReceiptName;
		public float AbsoluteValue;
		public float ValueFactor
		{
			get
			{
				return Convert.ToSingle((int)Type);
			}
			private set { }
		}
		public enum ItemType {None = 0, Expense = -1, Revenue = 1}
		public ItemType Type;

		public float Value
		{
			get
			{
				return ValueFactor * AbsoluteValue;
			}
			private set { }
		}

		public BudgetItem()
		{
			ReceiptName = "Unknown";
		}

		/// <summary>
		/// Compares to another budget position using Value and Factor.
		/// </summary>
		/// <param name="obj">Another BudgetPosition</param>
		/// <returns>Returns 1 if this one is higher, 0 if they're equal and -1 if this one is lower.</returns>
		public int CompareTo(object obj)
		{
			//Convert input to Budget posistion
			BudgetItem otherBudgetPosition = obj as BudgetItem;

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
				throw new ArgumentException("Object is not a BudgetPosition.");
		}
	}
}
