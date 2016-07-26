namespace BudgetManagerWindowsForms
{
	partial class AddAnItemWindow
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.valueLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.billingDatePortionDTPckr = new System.Windows.Forms.DateTimePicker();
			this.billingTimePortionDTPckr = new System.Windows.Forms.DateTimePicker();
			this.itemTypeLabel = new System.Windows.Forms.Label();
			this.billingDateLabel = new System.Windows.Forms.Label();
			this.receiptNameLabel = new System.Windows.Forms.Label();
			this.valueTextBox = new System.Windows.Forms.TextBox();
			this.itemTypeComboBox = new System.Windows.Forms.ComboBox();
			this.receiptNameTextBox = new System.Windows.Forms.TextBox();
			this.addAnItemButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.69231F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.30769F));
			this.tableLayoutPanel1.Controls.Add(this.valueLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.itemTypeLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.billingDateLabel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.receiptNameLabel, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.valueTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.itemTypeComboBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.receiptNameTextBox, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.addAnItemButton, 0, 4);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 190);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// valueLabel
			// 
			this.valueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.valueLabel.AutoSize = true;
			this.valueLabel.Location = new System.Drawing.Point(3, 6);
			this.valueLabel.Name = "valueLabel";
			this.valueLabel.Size = new System.Drawing.Size(34, 13);
			this.valueLabel.TabIndex = 0;
			this.valueLabel.Text = "Value";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.billingDatePortionDTPckr, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.billingTimePortionDTPckr, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(87, 53);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(170, 19);
			this.tableLayoutPanel2.TabIndex = 8;
			// 
			// billingDatePortionDTPckr
			// 
			this.billingDatePortionDTPckr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.billingDatePortionDTPckr.Location = new System.Drawing.Point(3, 3);
			this.billingDatePortionDTPckr.Name = "billingDatePortionDTPckr";
			this.billingDatePortionDTPckr.Size = new System.Drawing.Size(79, 20);
			this.billingDatePortionDTPckr.TabIndex = 0;
			// 
			// billingTimePortionDTPckr
			// 
			this.billingTimePortionDTPckr.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.billingTimePortionDTPckr.Location = new System.Drawing.Point(88, 3);
			this.billingTimePortionDTPckr.Name = "billingTimePortionDTPckr";
			this.billingTimePortionDTPckr.Size = new System.Drawing.Size(79, 20);
			this.billingTimePortionDTPckr.TabIndex = 1;
			// 
			// itemTypeLabel
			// 
			this.itemTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.itemTypeLabel.AutoSize = true;
			this.itemTypeLabel.Location = new System.Drawing.Point(3, 31);
			this.itemTypeLabel.Name = "itemTypeLabel";
			this.itemTypeLabel.Size = new System.Drawing.Size(50, 13);
			this.itemTypeLabel.TabIndex = 1;
			this.itemTypeLabel.Text = "Item type";
			// 
			// billingDateLabel
			// 
			this.billingDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.billingDateLabel.AutoSize = true;
			this.billingDateLabel.Location = new System.Drawing.Point(3, 56);
			this.billingDateLabel.Name = "billingDateLabel";
			this.billingDateLabel.Size = new System.Drawing.Size(58, 13);
			this.billingDateLabel.TabIndex = 2;
			this.billingDateLabel.Text = "Billing date";
			// 
			// receiptNameLabel
			// 
			this.receiptNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.receiptNameLabel.AutoSize = true;
			this.receiptNameLabel.Location = new System.Drawing.Point(3, 81);
			this.receiptNameLabel.Name = "receiptNameLabel";
			this.receiptNameLabel.Size = new System.Drawing.Size(73, 13);
			this.receiptNameLabel.TabIndex = 3;
			this.receiptNameLabel.Text = "Receipt name";
			// 
			// valueTextBox
			// 
			this.valueTextBox.Location = new System.Drawing.Point(87, 3);
			this.valueTextBox.Name = "valueTextBox";
			this.valueTextBox.Size = new System.Drawing.Size(170, 20);
			this.valueTextBox.TabIndex = 4;
			// 
			// itemTypeComboBox
			// 
			this.itemTypeComboBox.FormattingEnabled = true;
			this.itemTypeComboBox.Items.AddRange(new object[] {
            "Expense",
            "Revenue"});
			this.itemTypeComboBox.Location = new System.Drawing.Point(87, 28);
			this.itemTypeComboBox.Name = "itemTypeComboBox";
			this.itemTypeComboBox.Size = new System.Drawing.Size(170, 21);
			this.itemTypeComboBox.TabIndex = 5;
			// 
			// receiptNameTextBox
			// 
			this.receiptNameTextBox.Location = new System.Drawing.Point(87, 78);
			this.receiptNameTextBox.Name = "receiptNameTextBox";
			this.receiptNameTextBox.Size = new System.Drawing.Size(170, 20);
			this.receiptNameTextBox.TabIndex = 7;
			// 
			// addAnItemButton
			// 
			this.addAnItemButton.Location = new System.Drawing.Point(3, 103);
			this.addAnItemButton.Name = "addAnItemButton";
			this.addAnItemButton.Size = new System.Drawing.Size(78, 23);
			this.addAnItemButton.TabIndex = 9;
			this.addAnItemButton.Text = "Add";
			this.addAnItemButton.UseVisualStyleBackColor = true;
			this.addAnItemButton.Click += new System.EventHandler(this.addAnItemButton_Click);
			// 
			// AddAnItemWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "AddAnItemWindow";
			this.Text = "Add new item";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label valueLabel;
		private System.Windows.Forms.Label itemTypeLabel;
		private System.Windows.Forms.Label billingDateLabel;
		private System.Windows.Forms.Label receiptNameLabel;
		private System.Windows.Forms.TextBox valueTextBox;
		private System.Windows.Forms.ComboBox itemTypeComboBox;
		private System.Windows.Forms.TextBox receiptNameTextBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DateTimePicker billingDatePortionDTPckr;
		private System.Windows.Forms.DateTimePicker billingTimePortionDTPckr;
		private System.Windows.Forms.Button addAnItemButton;
	}
}