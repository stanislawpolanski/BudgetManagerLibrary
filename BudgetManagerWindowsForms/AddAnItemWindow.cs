using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetManagerLibrary;

namespace BudgetManagerWindowsForms
{
	public partial class AddAnItemWindow : Form
	{
		MainWindow MW;
		public AddAnItemWindow(MainWindow mw)
		{
			this.MW = mw;
			InitializeComponent();
		}

		private void addAnItemButton_Click(object sender, EventArgs e)
		{
			BudgetItem bi = new BudgetItem();
			bi.AbsoluteValue = Convert.ToSingle(valueTextBox.Text);
			DateTime BillingDate = billingDatePortionDTPckr.Value.Date + billingTimePortionDTPckr.Value.TimeOfDay;
			bi.BillingDate = BillingDate;
			BudgetItem.ItemType itmtp;
			Enum.TryParse(itemTypeComboBox.Text, out itmtp);
			bi.Type = itmtp;
			bi.ReceiptName = receiptNameTextBox.Text;
			bi.BookingDate = DateTime.Now;
			MW.AddNewItem(bi);
		}
	}
}
