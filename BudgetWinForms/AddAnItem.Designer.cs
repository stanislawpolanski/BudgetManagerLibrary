namespace BudgetWinForms
{
	partial class AddAnItem
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
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.expenseRadioButton = new System.Windows.Forms.RadioButton();
			this.revenueRadioButton = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.datePortionDTP = new System.Windows.Forms.DateTimePicker();
			this.timePortionDTP = new System.Windows.Forms.DateTimePicker();
			this.valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.receiptNameTextBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Type";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Value";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Receipt name";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Billing date";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.expenseRadioButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.revenueRadioButton, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(82, 29);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 48);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// expenseRadioButton
			// 
			this.expenseRadioButton.AutoSize = true;
			this.expenseRadioButton.Location = new System.Drawing.Point(3, 3);
			this.expenseRadioButton.Name = "expenseRadioButton";
			this.expenseRadioButton.Size = new System.Drawing.Size(66, 17);
			this.expenseRadioButton.TabIndex = 0;
			this.expenseRadioButton.TabStop = true;
			this.expenseRadioButton.Text = "Expense";
			this.expenseRadioButton.UseVisualStyleBackColor = true;
			// 
			// revenueRadioButton
			// 
			this.revenueRadioButton.AutoSize = true;
			this.revenueRadioButton.Location = new System.Drawing.Point(3, 27);
			this.revenueRadioButton.Name = "revenueRadioButton";
			this.revenueRadioButton.Size = new System.Drawing.Size(69, 17);
			this.revenueRadioButton.TabIndex = 1;
			this.revenueRadioButton.TabStop = true;
			this.revenueRadioButton.Text = "Revenue";
			this.revenueRadioButton.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.timePortionDTP, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.datePortionDTP, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(82, 83);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(327, 32);
			this.tableLayoutPanel3.TabIndex = 7;
			// 
			// datePortionDTP
			// 
			this.datePortionDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.datePortionDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePortionDTP.Location = new System.Drawing.Point(3, 6);
			this.datePortionDTP.Name = "datePortionDTP";
			this.datePortionDTP.Size = new System.Drawing.Size(200, 20);
			this.datePortionDTP.TabIndex = 0;
			// 
			// timePortionDTP
			// 
			this.timePortionDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.timePortionDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.timePortionDTP.Location = new System.Drawing.Point(209, 6);
			this.timePortionDTP.Name = "timePortionDTP";
			this.timePortionDTP.Size = new System.Drawing.Size(100, 20);
			this.timePortionDTP.TabIndex = 1;
			// 
			// valueNumericUpDown
			// 
			this.valueNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.valueNumericUpDown.DecimalPlaces = 2;
			this.valueNumericUpDown.Location = new System.Drawing.Point(82, 3);
			this.valueNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.valueNumericUpDown.Name = "valueNumericUpDown";
			this.valueNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.valueNumericUpDown.TabIndex = 8;
			// 
			// receiptNameTextBox
			// 
			this.receiptNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.receiptNameTextBox.Location = new System.Drawing.Point(82, 121);
			this.receiptNameTextBox.Name = "receiptNameTextBox";
			this.receiptNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.receiptNameTextBox.TabIndex = 9;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(82, 147);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 10;
			this.addButton.Text = "Add an item";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.receiptNameTextBox, 1, 3);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 2);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.valueNumericUpDown, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.addButton, 1, 4);
			this.tableLayoutPanel4.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tableLayoutPanel4.RowCount = 5;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(433, 189);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// AddAnItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(433, 180);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Name = "AddAnItem";
			this.Text = "AddAnItem";
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.RadioButton expenseRadioButton;
		private System.Windows.Forms.RadioButton revenueRadioButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.DateTimePicker datePortionDTP;
		private System.Windows.Forms.DateTimePicker timePortionDTP;
		private System.Windows.Forms.NumericUpDown valueNumericUpDown;
		private System.Windows.Forms.TextBox receiptNameTextBox;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
	}
}