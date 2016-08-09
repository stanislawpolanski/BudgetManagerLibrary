using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetManagerLibrary
{
	/// <summary>
	/// The collection of budget items.
	/// </summary>
	public class ItemsList : List<Item>
	{

		/// <summary>
		/// Computes and returns the balance.
		/// </summary>
		internal float GetBalance
		{
			get
			{
				return this.Sum(bpl => bpl.Value);
			}
			private set { }
		}
	}
}