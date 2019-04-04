namespace PayrollGUI
{
	partial class WeeklyPayroll
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ( );
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.ssnEntrryLabel = new System.Windows.Forms.Label();
			this.ssn01TextBox = new System.Windows.Forms.TextBox();
			this.ssn02TextBox = new System.Windows.Forms.TextBox();
			this.ssn03TextBox = new System.Windows.Forms.TextBox();
			this.ssnShowLabel = new System.Windows.Forms.Label();
			this.showPayrollButton = new System.Windows.Forms.Button();
			this.nameEntryLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameShowLabel = new System.Windows.Forms.Label();
			this.hourlyPayRateEntryLabel = new System.Windows.Forms.Label();
			this.hourlyPayRateShowLabel = new System.Windows.Forms.Label();
			this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
			this.hoursWorkedEntryLabel = new System.Windows.Forms.Label();
			this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
			this.hoursWorkedShowLabel = new System.Windows.Forms.Label();
			this.grossPayShowLabel = new System.Windows.Forms.Label();
			this.federalWithholdingShowLabel = new System.Windows.Forms.Label();
			this.stateWithholdingShowLabel = new System.Windows.Forms.Label();
			this.netPayShowLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ssnEntrryLabel
			// 
			this.ssnEntrryLabel.AutoSize = true;
			this.ssnEntrryLabel.Location = new System.Drawing.Point(25, 37);
			this.ssnEntrryLabel.Name = "ssnEntrryLabel";
			this.ssnEntrryLabel.Size = new System.Drawing.Size(155, 17);
			this.ssnEntrryLabel.TabIndex = 0;
			this.ssnEntrryLabel.Text = "Social Security Number";
			// 
			// ssn01TextBox
			// 
			this.ssn01TextBox.Location = new System.Drawing.Point(211, 37);
			this.ssn01TextBox.Name = "ssn01TextBox";
			this.ssn01TextBox.Size = new System.Drawing.Size(50, 22);
			this.ssn01TextBox.TabIndex = 1;
			// 
			// ssn02TextBox
			// 
			this.ssn02TextBox.Location = new System.Drawing.Point(278, 37);
			this.ssn02TextBox.Name = "ssn02TextBox";
			this.ssn02TextBox.Size = new System.Drawing.Size(50, 22);
			this.ssn02TextBox.TabIndex = 2;
			// 
			// ssn03TextBox
			// 
			this.ssn03TextBox.Location = new System.Drawing.Point(341, 37);
			this.ssn03TextBox.Name = "ssn03TextBox";
			this.ssn03TextBox.Size = new System.Drawing.Size(50, 22);
			this.ssn03TextBox.TabIndex = 3;
			// 
			// ssnShowLabel
			// 
			this.ssnShowLabel.AutoSize = true;
			this.ssnShowLabel.Location = new System.Drawing.Point(25, 281);
			this.ssnShowLabel.Name = "ssnShowLabel";
			this.ssnShowLabel.Size = new System.Drawing.Size(155, 17);
			this.ssnShowLabel.TabIndex = 11;
			this.ssnShowLabel.Text = "Social Security Number";
			// 
			// showPayrollButton
			// 
			this.showPayrollButton.Location = new System.Drawing.Point(28, 233);
			this.showPayrollButton.Name = "showPayrollButton";
			this.showPayrollButton.Size = new System.Drawing.Size(161, 27);
			this.showPayrollButton.TabIndex = 10;
			this.showPayrollButton.Text = "Show Payroll";
			this.showPayrollButton.UseVisualStyleBackColor = true;
			this.showPayrollButton.Click += new System.EventHandler(this.ShowPayrollButton_Click);
			// 
			// nameEntryLabel
			// 
			this.nameEntryLabel.AutoSize = true;
			this.nameEntryLabel.Location = new System.Drawing.Point(25, 74);
			this.nameEntryLabel.Name = "nameEntryLabel";
			this.nameEntryLabel.Size = new System.Drawing.Size(45, 17);
			this.nameEntryLabel.TabIndex = 4;
			this.nameEntryLabel.Text = "Name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(215, 74);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(178, 22);
			this.nameTextBox.TabIndex = 5;
			// 
			// nameShowLabel
			// 
			this.nameShowLabel.AutoSize = true;
			this.nameShowLabel.Location = new System.Drawing.Point(25, 318);
			this.nameShowLabel.Name = "nameShowLabel";
			this.nameShowLabel.Size = new System.Drawing.Size(45, 17);
			this.nameShowLabel.TabIndex = 12;
			this.nameShowLabel.Text = "Name";
			// 
			// hourlyPayRateEntryLabel
			// 
			this.hourlyPayRateEntryLabel.AutoSize = true;
			this.hourlyPayRateEntryLabel.Location = new System.Drawing.Point(25, 115);
			this.hourlyPayRateEntryLabel.Name = "hourlyPayRateEntryLabel";
			this.hourlyPayRateEntryLabel.Size = new System.Drawing.Size(111, 17);
			this.hourlyPayRateEntryLabel.TabIndex = 6;
			this.hourlyPayRateEntryLabel.Text = "Hourly Pay Rate";
			// 
			// hourlyPayRateShowLabel
			// 
			this.hourlyPayRateShowLabel.AutoSize = true;
			this.hourlyPayRateShowLabel.Location = new System.Drawing.Point(25, 355);
			this.hourlyPayRateShowLabel.Name = "hourlyPayRateShowLabel";
			this.hourlyPayRateShowLabel.Size = new System.Drawing.Size(111, 17);
			this.hourlyPayRateShowLabel.TabIndex = 13;
			this.hourlyPayRateShowLabel.Text = "Hourly Pay Rate";
			// 
			// hourlyPayRateTextBox
			// 
			this.hourlyPayRateTextBox.Location = new System.Drawing.Point(215, 115);
			this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
			this.hourlyPayRateTextBox.Size = new System.Drawing.Size(175, 22);
			this.hourlyPayRateTextBox.TabIndex = 7;
			// 
			// hoursWorkedEntryLabel
			// 
			this.hoursWorkedEntryLabel.AutoSize = true;
			this.hoursWorkedEntryLabel.Location = new System.Drawing.Point(25, 159);
			this.hoursWorkedEntryLabel.Name = "hoursWorkedEntryLabel";
			this.hoursWorkedEntryLabel.Size = new System.Drawing.Size(99, 17);
			this.hoursWorkedEntryLabel.TabIndex = 8;
			this.hoursWorkedEntryLabel.Text = "Hours Worked";
			// 
			// hoursWorkedTextBox
			// 
			this.hoursWorkedTextBox.Location = new System.Drawing.Point(213, 159);
			this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
			this.hoursWorkedTextBox.Size = new System.Drawing.Size(176, 22);
			this.hoursWorkedTextBox.TabIndex = 9;
			// 
			// hoursWorkedShowLabel
			// 
			this.hoursWorkedShowLabel.AutoSize = true;
			this.hoursWorkedShowLabel.Location = new System.Drawing.Point(25, 397);
			this.hoursWorkedShowLabel.Name = "hoursWorkedShowLabel";
			this.hoursWorkedShowLabel.Size = new System.Drawing.Size(99, 17);
			this.hoursWorkedShowLabel.TabIndex = 14;
			this.hoursWorkedShowLabel.Text = "Hours Worked";
			// 
			// grossPayShowLabel
			// 
			this.grossPayShowLabel.AutoSize = true;
			this.grossPayShowLabel.Location = new System.Drawing.Point(28, 438);
			this.grossPayShowLabel.Name = "grossPayShowLabel";
			this.grossPayShowLabel.Size = new System.Drawing.Size(74, 17);
			this.grossPayShowLabel.TabIndex = 15;
			this.grossPayShowLabel.Text = "Gross Pay";
			// 
			// federalWithholdingShowLabel
			// 
			this.federalWithholdingShowLabel.AutoSize = true;
			this.federalWithholdingShowLabel.Location = new System.Drawing.Point(28, 475);
			this.federalWithholdingShowLabel.Name = "federalWithholdingShowLabel";
			this.federalWithholdingShowLabel.Size = new System.Drawing.Size(134, 17);
			this.federalWithholdingShowLabel.TabIndex = 16;
			this.federalWithholdingShowLabel.Text = "Federal Withholding";
			// 
			// stateWithholdingShowLabel
			// 
			this.stateWithholdingShowLabel.AutoSize = true;
			this.stateWithholdingShowLabel.Location = new System.Drawing.Point(28, 515);
			this.stateWithholdingShowLabel.Name = "stateWithholdingShowLabel";
			this.stateWithholdingShowLabel.Size = new System.Drawing.Size(119, 17);
			this.stateWithholdingShowLabel.TabIndex = 17;
			this.stateWithholdingShowLabel.Text = "State Withholding";
			// 
			// netPayShowLabel
			// 
			this.netPayShowLabel.AutoSize = true;
			this.netPayShowLabel.Location = new System.Drawing.Point(28, 556);
			this.netPayShowLabel.Name = "netPayShowLabel";
			this.netPayShowLabel.Size = new System.Drawing.Size(58, 17);
			this.netPayShowLabel.TabIndex = 18;
			this.netPayShowLabel.Text = "Net Pay";
			// 
			// WeeklyPayroll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 647);
			this.Controls.Add(this.netPayShowLabel);
			this.Controls.Add(this.stateWithholdingShowLabel);
			this.Controls.Add(this.federalWithholdingShowLabel);
			this.Controls.Add(this.grossPayShowLabel);
			this.Controls.Add(this.hoursWorkedShowLabel);
			this.Controls.Add(this.hoursWorkedTextBox);
			this.Controls.Add(this.hoursWorkedEntryLabel);
			this.Controls.Add(this.hourlyPayRateTextBox);
			this.Controls.Add(this.hourlyPayRateShowLabel);
			this.Controls.Add(this.hourlyPayRateEntryLabel);
			this.Controls.Add(this.nameShowLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameEntryLabel);
			this.Controls.Add(this.showPayrollButton);
			this.Controls.Add(this.ssnShowLabel);
			this.Controls.Add(this.ssn03TextBox);
			this.Controls.Add(this.ssn02TextBox);
			this.Controls.Add(this.ssn01TextBox);
			this.Controls.Add(this.ssnEntrryLabel);
			this.Name = "WeeklyPayroll";
			this.Text = "Weekly Payroll";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ssnEntrryLabel;
		private System.Windows.Forms.TextBox ssn01TextBox;
		private System.Windows.Forms.TextBox ssn02TextBox;
		private System.Windows.Forms.TextBox ssn03TextBox;
		private System.Windows.Forms.Label ssnShowLabel;
		private System.Windows.Forms.Button showPayrollButton;
		private System.Windows.Forms.Label nameEntryLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label nameShowLabel;
		private System.Windows.Forms.Label hourlyPayRateEntryLabel;
		private System.Windows.Forms.Label hourlyPayRateShowLabel;
		private System.Windows.Forms.TextBox hourlyPayRateTextBox;
		private System.Windows.Forms.Label hoursWorkedEntryLabel;
		private System.Windows.Forms.TextBox hoursWorkedTextBox;
		private System.Windows.Forms.Label hoursWorkedShowLabel;
		private System.Windows.Forms.Label grossPayShowLabel;
		private System.Windows.Forms.Label federalWithholdingShowLabel;
		private System.Windows.Forms.Label stateWithholdingShowLabel;
		private System.Windows.Forms.Label netPayShowLabel;
	}
}

