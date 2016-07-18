using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Models
{
	public interface IDataModel
	{
		bool LoadBudget(string accessString);
		Budget GetBudget();
		bool AddRow(BudgetItem bp);
	}
}
