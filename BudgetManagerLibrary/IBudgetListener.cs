using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Models
{
	public interface IBudgetListener
	{
		void SubscribeToBudget(Budget b);
	}
}
