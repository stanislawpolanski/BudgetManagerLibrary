using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Models
{
	interface IDataModel
	{
		bool LoadBudget(string dataSourcePath);
		Budget GetBudget();
		bool AddRow(BudgetPosition bp);
		BudgetPosition GetRow(int budgetPositionId);
	}
}
