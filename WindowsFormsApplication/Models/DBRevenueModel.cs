using BudgetManagerLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.Models
{
	
	class DBRevenueModel : DBModel
	{
		public void AddRow(Revenue rvn)
		{
			SqlCommand cmdAddPosition = new SqlCommand("INSERT INTO BudgetPositions(Value, PositionType, ReceiptName, BillingDate) VALUES(@value,  1, @rcpName, @bkngDate)", base.DBConnection);

			cmdAddPosition.Parameters.AddWithValue("@value", rvn.Value.ToString());
			cmdAddPosition.Parameters.AddWithValue("@rcpName", rvn.ReceiptName);
			cmdAddPosition.Parameters.AddWithValue("@bkngDate", rvn.BillingDate.ToString());
			cmdAddPosition.ExecuteNonQuery();
		}
	}
}
