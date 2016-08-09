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

namespace BudgetWinForms
{
	public partial class AddAnItem : Form
	{

		public AddAnItem()
		{
			InitializeComponent();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			Item bi = new Item();
			bi.AbsoluteValue = (float)valueNumericUpDown.Value;

			if (expenseRadioButton.Checked)
				bi.Type = Item.ItemType.Expense;
			else if (revenueRadioButton.Checked)
				bi.Type = Item.ItemType.Revenue;
			else
			{
				MessageBox.Show("Choose a type!");
				return;
			}

			bi.BookingDate = DateTime.Now;

			bi.BillingDate = datePortionDTP.Value.Date + timePortionDTP.Value.TimeOfDay;

			bi.ReceiptName = receiptNameTextBox.Text;

			MainWindow ownr = Owner as MainWindow;
			ownr.WriteNewItem(bi);
			MessageBox.Show("Item added.");
		}
	}
}
