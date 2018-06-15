using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//test
namespace BudgetManagerLibrary.Models
{
	/// <summary>
	/// Interface for classes that listens to the budget changes.
	/// </summary>
	public interface IBudgetListener
	{
		/// <summary>
		/// Add a subscription.
		/// </summary>
		/// <param name="b">Budget class to which the listener subscribes.</param>
		void SubscribeToBudget(Budget b);
	}
}
