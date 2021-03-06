﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	/// <summary>
	/// Holds an info about value of budget position.
	/// </summary>
	public class Item : IComparable
	{
		public int Id
		{
			get;
			set;
		}
		public DateTime BookingDate
		{
			get;
			set;
		}
		public DateTime BillingDate
		{
			get;
			set;
		}
		public string ReceiptName
		{
			get;
			set;
		}
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

		public Item()
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
			Item otherBudgetPosition = obj as Item;

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
