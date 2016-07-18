using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
	/// <summary>
	/// Budget class represents a budget. It holds collection of budget positions and gets the balance from the collection.
	/// </summary>
	public class Budget
	{
		/// <summary>
		/// Collection of budget positions like revenues, spends etc.
		/// </summary>
		public BudgetItemsList PositionsList = new BudgetItemsList();

		/// <summary>
		/// Adds a position into the collection.
		/// </summary>
		/// <param name="bp">Budget position.</param>
		public void AddPosition(BudgetItem bp)
		{
			this.PositionsList.Add(bp);
		}

		/// <summary>
		/// Gets the balance from the collection.
		/// </summary>
		/// <returns>Balance</returns>
		public float GetBalance()
		{
			return PositionsList.GetBalance;
		}

		public DataTable ToDataTable()
		{

			throw new NotImplementedException();
		}
	}
}
