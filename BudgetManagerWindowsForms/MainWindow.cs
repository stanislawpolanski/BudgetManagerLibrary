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

namespace BudgetManagerWindowsForms
{
	public partial class MainWindow : Form
	{
		DataModelFactory DMF;
		IDataModel DataModel;
		Budget CurrentBudget;

		public void AddDataModelFactory(DataModelFactory dmf)
		{
			this.DMF = dmf;
		}
		public MainWindow()
		{
			InitializeComponent();			
		}






			
		private void addAnItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddAnItemWindow aaiw = new AddAnItemWindow(this);
			aaiw.Show();
		}

		private void openXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openXMLDialogWindows = new OpenFileDialog();
			openXMLDialogWindows.Filter = "XML files (xml)|*.xml|All files (*.*)|*.*";

			//TODO WCZYTYWANIE DOWOLNEGO PLIKU
			DataModel = DMF.CreateDataModel(DataModelFactory.DataModelSource.XML);
			DataModel.LoadBudget("d:/SampleDataFile.xml");
			CurrentBudget = DataModel.GetBudget();
			//TODO JAKIES LADOWANIE DANYCH DO DATAGRIDVIEW
			DataTable dt = new DataTable();
			dt.Columns.Add("number");
			dt.Rows.Add(15);
			dt.Rows.Add(17);
			dataGV.Columns.Add("number", "num");
			dataGV.DataSource = dt;

		}

		public bool AddNewItem(BudgetItem bi)
		{
			try
			{
				CurrentBudget.AddNewItem(bi);
			}
			catch (Exception)
			{
				MessageBox.Show("Item not added");
				return false;
			}

			MessageBox.Show("Item added");
			//TODO Resetting the view
			budgetBindingSource.DataSource = CurrentBudget;
			return true;
		}
	}
}
/*
//Uruchomienie okna wczytywania pliku z filtrami.
OpenFileDialog oknoWczytywania = new OpenFileDialog();
oknoWczytywania.Filter = "Pliki XML (xml)|*.xml|Wszystkie pliki (*.*)|*.*";

			//Inicjalizacja czytnika WCXML. Do ew. rozwinięcia na inne czytniki pliku punktów (CzytnikPlikuPunktow).
			this.CzytnikPliku = new CzytnikPlikuPunktowWCXML();


            try
            {
                if (oknoWczytywania.ShowDialog() == DialogResult.OK)

				{
	this.CzytnikPliku.Wczytaj(oknoWczytywania.FileName);
	this.stworzTabele(CzytnikPliku.ZwrocListe());

	//Jeśli wszystko ok, to wyświetlamy odpowiedni komunikat w pasku statusu.
	PasekStatusuLabel.Text = "Plik " + oknoWczytywania.SafeFileName + " wczytany pomyślnie";
}
}
            catch (Exception exc)
            {
                this.obsluzBlad(exc, "Błędny plik XML (wczytaj prawidłowy plik osiadań: Plik->Wczytaj plik osiadań)");
                return;
}
*/