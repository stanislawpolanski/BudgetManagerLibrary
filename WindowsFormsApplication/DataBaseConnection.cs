using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
	class DataBaseConnection
	{
		internal static string GetConnectionString()
		{
			//Assume failure.
			string returnValue = null;

			//Look for the name in the connectionStrings section.
			ConnectionStringSettings settings =
			ConfigurationManager.ConnectionStrings["WindowsFormsApplication.Properties.Settings.connString"];

			//If found, return the connection string.
			if (settings != null)
				returnValue = settings.ConnectionString;

			return returnValue;
		}
	}
}
