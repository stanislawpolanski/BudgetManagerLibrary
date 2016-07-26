using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Models
{
	public interface IDataModel : IBudgetListener
	{
		bool LoadBudget(string accessString);
		Budget GetBudget();
	}
}
