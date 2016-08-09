using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Models
{
	/// <summary>
	/// Produces models for reading and writing budget data.
	/// </summary>
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

		/// <summary>
		/// Looks for a specified model and returns an instance of him.
		/// </summary>
		/// <param name="modelName">Model name.</param>
		/// <returns>IDataModel compatible model.</returns>
		public IDataModel CreateDataModel(DataModelSource modelName)
		{
			IDataModel dataModel;
			DataModelTypes.TryGetValue(modelName, out dataModel);
			return dataModel;
		}
	}
}
