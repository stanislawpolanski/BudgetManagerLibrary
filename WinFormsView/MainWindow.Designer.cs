namespace WinFormsView
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.BudgetItemsDataGridView = new System.Windows.Forms.DataGridView();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAnItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BudgetItemsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.itemsToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(284, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// BudgetItemsDataGridView
			// 
			this.BudgetItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BudgetItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BudgetItemsDataGridView.Location = new System.Drawing.Point(0, 24);
			this.BudgetItemsDataGridView.Name = "BudgetItemsDataGridView";
			this.BudgetItemsDataGridView.Size = new System.Drawing.Size(284, 238);
			this.BudgetItemsDataGridView.TabIndex = 1;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openXMLFileToolStripMenuItem,
            this.closeAFileToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openXMLFileToolStripMenuItem
			// 
			this.openXMLFileToolStripMenuItem.Name = "openXMLFileToolStripMenuItem";
			this.openXMLFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openXMLFileToolStripMenuItem.Text = "Open XML file";
			// 
			// closeAFileToolStripMenuItem
			// 
			this.closeAFileToolStripMenuItem.Name = "closeAFileToolStripMenuItem";
			this.closeAFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.closeAFileToolStripMenuItem.Text = "Close file";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// itemsToolStripMenuItem
			// 
			this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAnItemToolStripMenuItem});
			this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
			this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.itemsToolStripMenuItem.Text = "Items";
			// 
			// addAnItemToolStripMenuItem
			// 
			this.addAnItemToolStripMenuItem.Name = "addAnItemToolStripMenuItem";
			this.addAnItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.addAnItemToolStripMenuItem.Text = "Add an item";
			this.addAnItemToolStripMenuItem.Click += new System.EventHandler(this.addAnItemToolStripMenuItem_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.BudgetItemsDataGridView);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainWindow";
			this.Text = "MainWindow";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BudgetItemsDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.DataGridView BudgetItemsDataGridView;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openXMLFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeAFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addAnItemToolStripMenuItem;
	}
}