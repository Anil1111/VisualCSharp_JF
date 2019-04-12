namespace AdmissionGUI
{
	partial class CollegeAdmissionForm
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
			this.gpaLabel = new System.Windows.Forms.Label();
			this.gpaTextBox = new System.Windows.Forms.TextBox();
			this.adminTestScoreLabel = new System.Windows.Forms.Label();
			this.testScoreTextBox = new System.Windows.Forms.TextBox();
			this.adminResultLabel = new System.Windows.Forms.Label();
			this.requirementsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// gpaLabel
			// 
			this.gpaLabel.AutoSize = true;
			this.gpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpaLabel.Location = new System.Drawing.Point(49, 53);
			this.gpaLabel.Name = "gpaLabel";
			this.gpaLabel.Size = new System.Drawing.Size(293, 20);
			this.gpaLabel.TabIndex = 0;
			this.gpaLabel.Text = "Enter students Grade Point Average:  ";
			// 
			// gpaTextBox
			// 
			this.gpaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpaTextBox.Location = new System.Drawing.Point(416, 46);
			this.gpaTextBox.Name = "gpaTextBox";
			this.gpaTextBox.Size = new System.Drawing.Size(65, 27);
			this.gpaTextBox.TabIndex = 1;
			// 
			// adminTestScoreLabel
			// 
			this.adminTestScoreLabel.AutoSize = true;
			this.adminTestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminTestScoreLabel.Location = new System.Drawing.Point(49, 88);
			this.adminTestScoreLabel.Name = "adminTestScoreLabel";
			this.adminTestScoreLabel.Size = new System.Drawing.Size(294, 20);
			this.adminTestScoreLabel.TabIndex = 2;
			this.adminTestScoreLabel.Text = "Enter students admission test score:  ";
			// 
			// testScoreTextBox
			// 
			this.testScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.testScoreTextBox.Location = new System.Drawing.Point(416, 81);
			this.testScoreTextBox.Name = "testScoreTextBox";
			this.testScoreTextBox.Size = new System.Drawing.Size(65, 27);
			this.testScoreTextBox.TabIndex = 3;
			// 
			// adminResultLabel
			// 
			this.adminResultLabel.AutoSize = true;
			this.adminResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminResultLabel.Location = new System.Drawing.Point(49, 172);
			this.adminResultLabel.Name = "adminResultLabel";
			this.adminResultLabel.Size = new System.Drawing.Size(164, 20);
			this.adminResultLabel.TabIndex = 4;
			this.adminResultLabel.Text = "Admission Results:  ";
			// 
			// requirementsButton
			// 
			this.requirementsButton.Location = new System.Drawing.Point(49, 123);
			this.requirementsButton.Name = "requirementsButton";
			this.requirementsButton.Size = new System.Drawing.Size(152, 28);
			this.requirementsButton.TabIndex = 5;
			this.requirementsButton.Text = "Check Requirements";
			this.requirementsButton.UseVisualStyleBackColor = true;
			this.requirementsButton.Click += new System.EventHandler(this.RequirementsButton_Click);
			// 
			// CollegeAdmissionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 227);
			this.Controls.Add(this.requirementsButton);
			this.Controls.Add(this.adminResultLabel);
			this.Controls.Add(this.testScoreTextBox);
			this.Controls.Add(this.adminTestScoreLabel);
			this.Controls.Add(this.gpaTextBox);
			this.Controls.Add(this.gpaLabel);
			this.Name = "CollegeAdmissionForm";
			this.Text = "Admission Requirements";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label gpaLabel;
		private System.Windows.Forms.TextBox gpaTextBox;
		private System.Windows.Forms.Label adminTestScoreLabel;
		private System.Windows.Forms.TextBox testScoreTextBox;
		private System.Windows.Forms.Label adminResultLabel;
		private System.Windows.Forms.Button requirementsButton;
	}
}

