namespace BudgetManagerWindowsForms
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAnItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itemsListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.itemsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.itemsListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dataGV = new System.Windows.Forms.DataGridView();
			this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemsListBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemsListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemsListBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.itemToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(479, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fIleToolStripMenuItem
			// 
			this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openXMLFileToolStripMenuItem});
			this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
			this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fIleToolStripMenuItem.Text = "File";
			// 
			// openXMLFileToolStripMenuItem
			// 
			this.openXMLFileToolStripMenuItem.Name = "openXMLFileToolStripMenuItem";
			this.openXMLFileToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.openXMLFileToolStripMenuItem.Text = "Open XML file";
			this.openXMLFileToolStripMenuItem.Click += new System.EventHandler(this.openXMLFileToolStripMenuItem_Click);
			// 
			// itemToolStripMenuItem
			// 
			this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAnItemToolStripMenuItem});
			this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
			this.itemToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.itemToolStripMenuItem.Text = "Item";
			// 
			// addAnItemToolStripMenuItem
			// 
			this.addAnItemToolStripMenuItem.Name = "addAnItemToolStripMenuItem";
			this.addAnItemToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.addAnItemToolStripMenuItem.Text = "Add an item";
			this.addAnItemToolStripMenuItem.Click += new System.EventHandler(this.addAnItemToolStripMenuItem_Click);
			// 
			// itemsListBindingSource2
			// 
			this.itemsListBindingSource2.DataMember = "ItemsList";
			this.itemsListBindingSource2.DataSource = this.budgetBindingSource;
			// 
			// itemsListBindingSource
			// 
			this.itemsListBindingSource.DataMember = "ItemsList";
			this.itemsListBindingSource.DataSource = this.budgetBindingSource;
			// 
			// itemsListBindingSource1
			// 
			this.itemsListBindingSource1.DataMember = "ItemsList";
			this.itemsListBindingSource1.DataSource = this.budgetBindingSource;
			// 
			// dataGV
			// 
			this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGV.Location = new System.Drawing.Point(0, 24);
			this.dataGV.Name = "dataGV";
			this.dataGV.Size = new System.Drawing.Size(479, 238);
			this.dataGV.TabIndex = 1;
			// 
			// budgetBindingSource
			// 
			this.budgetBindingSource.DataSource = typeof(BudgetManagerLibrary.Budget);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 262);
			this.Controls.Add(this.dataGV);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.Text = "Main window";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemsListBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemsListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemsListBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addAnItemToolStripMenuItem;
		private System.Windows.Forms.BindingSource budgetBindingSource;
		private System.Windows.Forms.BindingSource itemsListBindingSource;
		private System.Windows.Forms.BindingSource itemsListBindingSource1;
		private System.Windows.Forms.BindingSource itemsListBindingSource2;
		private System.Windows.Forms.ToolStripMenuItem openXMLFileToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGV;
	}
}

