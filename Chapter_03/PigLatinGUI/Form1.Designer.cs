namespace PigLatinGUI
{
	partial class PigLatin
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
			this.pigLatinLabel = new System.Windows.Forms.Label();
			this.englishWordTextBox = new System.Windows.Forms.TextBox();
			this.pigLatinButton = new System.Windows.Forms.Button();
			this.pigWordLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pigLatinLabel
			// 
			this.pigLatinLabel.AutoSize = true;
			this.pigLatinLabel.Location = new System.Drawing.Point(23, 38);
			this.pigLatinLabel.Name = "pigLatinLabel";
			this.pigLatinLabel.Size = new System.Drawing.Size(224, 17);
			this.pigLatinLabel.TabIndex = 0;
			this.pigLatinLabel.Text = "Enter an english word to change:  ";
			// 
			// englishWordTextBox
			// 
			this.englishWordTextBox.Location = new System.Drawing.Point(266, 38);
			this.englishWordTextBox.Name = "englishWordTextBox";
			this.englishWordTextBox.Size = new System.Drawing.Size(100, 22);
			this.englishWordTextBox.TabIndex = 1;
			// 
			// pigLatinButton
			// 
			this.pigLatinButton.Location = new System.Drawing.Point(26, 78);
			this.pigLatinButton.Name = "pigLatinButton";
			this.pigLatinButton.Size = new System.Drawing.Size(128, 23);
			this.pigLatinButton.TabIndex = 2;
			this.pigLatinButton.Text = "Pig Latin Word";
			this.pigLatinButton.UseVisualStyleBackColor = true;
			this.pigLatinButton.Click += new System.EventHandler(this.PigLatinButton_Click);
			// 
			// pigWordLabel
			// 
			this.pigWordLabel.AutoSize = true;
			this.pigWordLabel.Location = new System.Drawing.Point(26, 117);
			this.pigWordLabel.Name = "pigWordLabel";
			this.pigWordLabel.Size = new System.Drawing.Size(119, 17);
			this.pigWordLabel.TabIndex = 3;
			this.pigWordLabel.Text = "Pig Latin Word is ";
			// 
			// PigLatin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 267);
			this.Controls.Add(this.pigWordLabel);
			this.Controls.Add(this.pigLatinButton);
			this.Controls.Add(this.englishWordTextBox);
			this.Controls.Add(this.pigLatinLabel);
			this.Name = "PigLatin";
			this.Text = "Pig Latin Game";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pigLatinLabel;
		private System.Windows.Forms.TextBox englishWordTextBox;
		private System.Windows.Forms.Button pigLatinButton;
		private System.Windows.Forms.Label pigWordLabel;
	}
}

