namespace SecondChancePayRateGUI
{
	partial class SecondChancePayRate
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
			if ( disposing && ( components != null ) )
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
			this.payRateLabel = new System.Windows.Forms.Label();
			this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
			this.checkPayRateButton = new System.Windows.Forms.Button();
			this.payRateResultlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// payRateLabel
			// 
			this.payRateLabel.AutoSize = true;
			this.payRateLabel.Location = new System.Drawing.Point(60, 66);
			this.payRateLabel.Name = "payRateLabel";
			this.payRateLabel.Size = new System.Drawing.Size(185, 17);
			this.payRateLabel.TabIndex = 0;
			this.payRateLabel.Text = "Enter your hourly pay rate:  ";
			// 
			// hourlyPayRateTextBox
			// 
			this.hourlyPayRateTextBox.Location = new System.Drawing.Point(274, 61);
			this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
			this.hourlyPayRateTextBox.Size = new System.Drawing.Size(100, 22);
			this.hourlyPayRateTextBox.TabIndex = 1;
			// 
			// checkPayRateButton
			// 
			this.checkPayRateButton.Location = new System.Drawing.Point(65, 106);
			this.checkPayRateButton.Name = "checkPayRateButton";
			this.checkPayRateButton.Size = new System.Drawing.Size(148, 30);
			this.checkPayRateButton.TabIndex = 2;
			this.checkPayRateButton.Text = "Check Pay Rate";
			this.checkPayRateButton.UseVisualStyleBackColor = true;
			this.checkPayRateButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// payRateResultlabel
			// 
			this.payRateResultlabel.AutoSize = true;
			this.payRateResultlabel.Location = new System.Drawing.Point(63, 172);
			this.payRateResultlabel.Name = "payRateResultlabel";
			this.payRateResultlabel.Size = new System.Drawing.Size(110, 17);
			this.payRateResultlabel.TabIndex = 3;
			this.payRateResultlabel.Text = "Pay Rate Result";
			// 
			// SecondChancePayRate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 335);
			this.Controls.Add(this.payRateResultlabel);
			this.Controls.Add(this.checkPayRateButton);
			this.Controls.Add(this.hourlyPayRateTextBox);
			this.Controls.Add(this.payRateLabel);
			this.Name = "SecondChancePayRate";
			this.Text = "Pay Rate Review";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label payRateLabel;
		private System.Windows.Forms.TextBox hourlyPayRateTextBox;
		private System.Windows.Forms.Button checkPayRateButton;
		private System.Windows.Forms.Label payRateResultlabel;
	}
}

