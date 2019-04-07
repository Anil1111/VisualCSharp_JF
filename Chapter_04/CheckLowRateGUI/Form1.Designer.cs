namespace CheckLowRateGUI
{
	partial class CheckLowRate
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
			this.hourlyPayRateLabel = new System.Windows.Forms.Label();
			this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
			this.checkMinWageButton = new System.Windows.Forms.Button();
			this.minimumWageLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// hourlyPayRateLabel
			// 
			this.hourlyPayRateLabel.AutoSize = true;
			this.hourlyPayRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hourlyPayRateLabel.Location = new System.Drawing.Point(35, 38);
			this.hourlyPayRateLabel.Name = "hourlyPayRateLabel";
			this.hourlyPayRateLabel.Size = new System.Drawing.Size(176, 20);
			this.hourlyPayRateLabel.TabIndex = 0;
			this.hourlyPayRateLabel.Text = "Enter Hourly Pay Rate";
			// 
			// hourlyPayRateTextBox
			// 
			this.hourlyPayRateTextBox.Location = new System.Drawing.Point(242, 38);
			this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
			this.hourlyPayRateTextBox.Size = new System.Drawing.Size(100, 22);
			this.hourlyPayRateTextBox.TabIndex = 1;
			// 
			// checkMinWageButton
			// 
			this.checkMinWageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkMinWageButton.Location = new System.Drawing.Point(38, 72);
			this.checkMinWageButton.Name = "checkMinWageButton";
			this.checkMinWageButton.Size = new System.Drawing.Size(146, 26);
			this.checkMinWageButton.TabIndex = 2;
			this.checkMinWageButton.Text = "Check Min Wage";
			this.checkMinWageButton.UseVisualStyleBackColor = true;
			this.checkMinWageButton.Click += new System.EventHandler(this.CheckMinWageButton_Click);
			// 
			// minimumWageLabel
			// 
			this.minimumWageLabel.AutoSize = true;
			this.minimumWageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minimumWageLabel.Location = new System.Drawing.Point(35, 121);
			this.minimumWageLabel.Name = "minimumWageLabel";
			this.minimumWageLabel.Size = new System.Drawing.Size(0, 20);
			this.minimumWageLabel.TabIndex = 3;
			// 
			// CheckLowRate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 310);
			this.Controls.Add(this.minimumWageLabel);
			this.Controls.Add(this.checkMinWageButton);
			this.Controls.Add(this.hourlyPayRateTextBox);
			this.Controls.Add(this.hourlyPayRateLabel);
			this.Name = "CheckLowRate";
			this.Text = "Check Minimum Wage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label hourlyPayRateLabel;
		private System.Windows.Forms.TextBox hourlyPayRateTextBox;
		private System.Windows.Forms.Button checkMinWageButton;
		private System.Windows.Forms.Label minimumWageLabel;
	}
}

