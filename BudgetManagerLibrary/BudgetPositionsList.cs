﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetManagerLibrary
{
	/// <summary>
	/// The class holds all budget positions.
	/// </summary>
	public class BudgetPositionsList : List<BudgetPosition>
	{
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