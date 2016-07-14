using BudgetManagerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.Models;

namespace WindowsFormsApplication
{
	public partial class AddRevenue : Form
	{
		public AddRevenue()
		{
			InitializeComponent();
		}



		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void addRevenueBtn_Click(object sender, EventArgs e)
		{
			//check if form is filled
			float absValue = 0;
			if (!Single.TryParse(valueTextBox.Text, out absValue))
			{
				MessageBox.Show("Not a proper value");
				return;
			}
			
			Revenue bp = new Revenue();
			bp.AbsoluteValue = absValue;
			bp.ReceiptName = receiptNameTextBox.Text;
			bp.BillingDate = Convert.ToDateTime(receiptDateTextBox.Text);

			DBRevenueModel dbrm = new DBRevenueModel();
			dbrm.AddRow(bp);

			MessageBox.Show("Revenue added.");

			//TODO LET THE BALANCE LABEL KNOW THE BALANCE HAS CHANGED
		}
	}
}
