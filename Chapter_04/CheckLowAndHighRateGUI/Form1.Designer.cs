namespace CheckLowAndHighRateGUI
{
	partial class CheckLowAndHighRateForm
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
			this.checkPayRateButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// hourlyPayRateLabel
			// 
			this.hourlyPayRateLabel.AutoSize = true;
			this.hourlyPayRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hourlyPayRateLabel.Location = new System.Drawing.Point(51, 41);
			this.hourlyPayRateLabel.Name = "hourlyPayRateLabel";
			this.hourlyPayRateLabel.Size = new System.Drawing.Size(179, 20);
			this.hourlyPayRateLabel.TabIndex = 0;
			this.hourlyPayRateLabel.Text = "Enter hourly pay rate:  ";
			// 
			// hourlyPayRateTextBox
			// 
			this.hourlyPayRateTextBox.Location = new System.Drawing.Point(267, 39);
			this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
			this.hourlyPayRateTextBox.Size = new System.Drawing.Size(100, 22);
			this.hourlyPayRateTextBox.TabIndex = 1;
			// 
			// checkPayRateButton
			// 
			this.checkPayRateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkPayRateButton.Location = new System.Drawing.Point(55, 82);
			this.checkPayRateButton.Name = "checkPayRateButton";
			this.checkPayRateButton.Size = new System.Drawing.Size(134, 29);
			this.checkPayRateButton.TabIndex = 2;
			this.checkPayRateButton.Text = "Check Pay Rate";
			this.checkPayRateButton.UseVisualStyleBackColor = true;
			this.checkPayRateButton.Click += new System.EventHandler(this.CheckPayRateButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLabel.Location = new System.Drawing.Point(55, 139);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(0, 20);
			this.resultLabel.TabIndex = 3;
			// 
			// CheckLowAndHighRateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 222);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.checkPayRateButton);
			this.Controls.Add(this.hourlyPayRateTextBox);
			this.Controls.Add(this.hourlyPayRateLabel);
			this.Name = "CheckLowAndHighRateForm";
			this.Text = "Check Hourly Pay Rate";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label hourlyPayRateLabel;
		private System.Windows.Forms.TextBox hourlyPayRateTextBox;
		private System.Windows.Forms.Button checkPayRateButton;
		private System.Windows.Forms.Label resultLabel;
	}
}

