using BudgetManagerLibrary;
using BudgetManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagerWindowsForms
{
	static class Program
	{
		//TODO CLEAN UP THE MESS
		static MainWindow MW;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MW = new MainWindow();
			DataModelFactory dmf = new DataModelFactory();
			MW.AddDataModelFactory(dmf);
			Application.Run(MW);
		}
	}
}
