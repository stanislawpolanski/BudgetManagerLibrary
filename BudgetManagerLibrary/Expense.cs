﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	class Expense : BudgetPosition
	{
		public string ReceiptId;
		public Expense()
		{
			base.Factor = -1;
		}

		public Expense(string RId) : this()
		{
			this.ReceiptId = RId;
		}
	}
}