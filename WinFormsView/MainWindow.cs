using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsView
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void addAnItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddItemWindow aiw = new AddItemWindow();
			aiw.Show();
		}
	}
}
