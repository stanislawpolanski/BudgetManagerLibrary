using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Models
{
	public class DataModelFactory
	{
		public enum DataModelSource { XML };

		private readonly IDictionary<DataModelSource, IDataModel> DataModelTypes;
		public DataModelFactory()
		{
			DataModelTypes = new Dictionary<DataModelSource, IDataModel>
			{
				{DataModelSource.XML, new XMLDataModel()}
			};
		}

		public IDataModel CreateDataModel(DataModelSource modelName)
		{
			IDataModel dataModel;
			DataModelTypes.TryGetValue(modelName, out dataModel);
			return dataModel;
		}
	}
}
