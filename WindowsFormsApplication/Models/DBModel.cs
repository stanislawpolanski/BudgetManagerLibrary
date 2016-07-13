using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Models
{
	class DBModel
	{
		internal string ConnectionString;

		public DBModel()
		{
			//Look for the name in the connectionStrings section.
			ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["WindowsFormsApplication.Properties.Settings.connString"];

			//If found, return the connection string.
			if (settings != null)
				ConnectionString = settings.ConnectionString;
			else
				throw new NullReferenceException("Couldn't retrieve connection string");
		}
	}
}
