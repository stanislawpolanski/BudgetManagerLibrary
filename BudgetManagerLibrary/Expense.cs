using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	public class Expense : BudgetPosition
	{
		public string ReceiptId;
		public Expense()
		{
			base.ValueFactor = -1;
		}

		public Expense(string RId) : this()
		{
			this.ReceiptId = RId;
		}
	}
}
