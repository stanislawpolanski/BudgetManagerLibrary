using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Models
{
	/// <summary>
	/// Interface for data models.
	/// </summary>
	public interface IDataModel : IBudgetListener
	{
		/// <summary>
		/// Tries to load a budget.
		/// </summary>
		/// <param name="accessString">String that gives the access to the budget. Can be file path, DB connection string etc.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		bool LoadBudget(string accessString);

		/// <summary>
		/// Loads a budget.
		/// </summary>
		/// <returns>Budget class.</returns>
		Budget GetBudget();
	}
}
