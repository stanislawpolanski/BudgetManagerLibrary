using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BudgetManagerLibrary.Models
{
	class XMLDataModel : IDataModel
	{
		private XDocument DataFile = null;
		public bool AddRow(BudgetPosition bp)
		{
			throw new NotImplementedException();
		}

		public Budget GetBudget()
		{
			//check if budget is loaded
			if (DataFile == null)
				throw new NullReferenceException("Data filed not loaded!");
			throw new NotImplementedException();
		}

		public BudgetPosition GetRow(int budgetPositionId)
		{
			throw new NotImplementedException();
		}

		public bool LoadBudget(string dataSourcePath)
		{
			try
			{
				DataFile = XDocument.Load(dataSourcePath);
				
			}
			catch(Exception e)
			{
				return false;
			}
			//TODO validation with xml schema
			//TODO loading XML to budget class
			return true;
		}
	}
}
