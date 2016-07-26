using BudgetManagerLibrary;
using BudgetManagerLibrary.Models;
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
	public partial class MainWindow : Form, IBudgetListener
	{
		public Budget CurrentBudget;
		public IDataModel CurrentDataModel;
		public MainWindow()
		{
			InitializeComponent();
		}

		public void BindData(string XMLFilePath)
		{
			DataModelFactory dmf = new DataModelFactory();
			CurrentDataModel = dmf.CreateDataModel(DataModelFactory.DataModelSource.XML);
			CurrentDataModel.LoadBudget(XMLFilePath);
			CurrentBudget = CurrentDataModel.GetBudget();
			this.SubscribeToBudget(CurrentBudget);
			RefreshDataGridView();
		}

		public void RefreshDataGridView()
		{
			dataGridView.DataSource = null;
			dataGridView.DataSource = CurrentBudget.ItemsList;
			balanceTbx.Text = CurrentBudget.GetBalance().ToString();
			itemsCountTbx.Text = CurrentBudget.ItemsList.Count().ToString();
		}

		public void SubscribeToBudget(Budget b)
		{
			b.ItemAddedEvent += new Budget.ItemAddedHandler(WriteNewItem);
		}

		private void WriteNewItem(Budget b, EventArgs e)
		{
			RefreshDataGridView();

		}

		public void WriteNewItem(BudgetItem bi)
		{
			CurrentBudget.AddNewItem(bi);
		}

		private void addAnItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddAnItem addAnItemForm = new AddAnItem();
			addAnItemForm.Show(this);
		}

		private void openXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Displays an OpenFileDialog so the user can select a budget file
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "XML files|*.xml|All files|*.*";
			openFileDialog1.Title = "Select a XML Budget file";

			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				BindData(openFileDialog1.InitialDirectory + openFileDialog1.FileName);
				
			}
		}

		private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentBudget = null;
			CurrentDataModel = null;
			//resetting the view
		}
	}
}
