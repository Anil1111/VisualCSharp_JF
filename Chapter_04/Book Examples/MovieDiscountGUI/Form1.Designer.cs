namespace MovieDiscountGUI
{
	partial class MovieDiscount
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
			this.ageEntryLabel = new System.Windows.Forms.Label();
			this.ageTextBox = new System.Windows.Forms.TextBox();
			this.movieRatingEntrylabel = new System.Windows.Forms.Label();
			this.movieRatingTextBox = new System.Windows.Forms.TextBox();
			this.discountLabel = new System.Windows.Forms.Label();
			this.determineDiscountButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ageEntryLabel
			// 
			this.ageEntryLabel.AutoSize = true;
			this.ageEntryLabel.Location = new System.Drawing.Point(40, 53);
			this.ageEntryLabel.Name = "ageEntryLabel";
			this.ageEntryLabel.Size = new System.Drawing.Size(151, 17);
			this.ageEntryLabel.TabIndex = 0;
			this.ageEntryLabel.Text = "Enter customers age:  ";
			// 
			// ageTextBox
			// 
			this.ageTextBox.Location = new System.Drawing.Point(244, 53);
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(100, 22);
			this.ageTextBox.TabIndex = 1;
			// 
			// movieRatingEntrylabel
			// 
			this.movieRatingEntrylabel.AutoSize = true;
			this.movieRatingEntrylabel.Location = new System.Drawing.Point(43, 99);
			this.movieRatingEntrylabel.Name = "movieRatingEntrylabel";
			this.movieRatingEntrylabel.Size = new System.Drawing.Size(135, 17);
			this.movieRatingEntrylabel.TabIndex = 2;
			this.movieRatingEntrylabel.Text = "Enter movie rating:  ";
			// 
			// movieRatingTextBox
			// 
			this.movieRatingTextBox.Location = new System.Drawing.Point(244, 93);
			this.movieRatingTextBox.Name = "movieRatingTextBox";
			this.movieRatingTextBox.Size = new System.Drawing.Size(100, 22);
			this.movieRatingTextBox.TabIndex = 3;
			// 
			// discountLabel
			// 
			this.discountLabel.AutoSize = true;
			this.discountLabel.Location = new System.Drawing.Point(43, 210);
			this.discountLabel.Name = "discountLabel";
			this.discountLabel.Size = new System.Drawing.Size(0, 17);
			this.discountLabel.TabIndex = 4;
			// 
			// determineDiscountButton
			// 
			this.determineDiscountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.6F);
			this.determineDiscountButton.Location = new System.Drawing.Point(46, 144);
			this.determineDiscountButton.Name = "determineDiscountButton";
			this.determineDiscountButton.Size = new System.Drawing.Size(89, 41);
			this.determineDiscountButton.TabIndex = 5;
			this.determineDiscountButton.Text = "Determine Discount";
			this.determineDiscountButton.UseVisualStyleBackColor = true;
			this.determineDiscountButton.Click += new System.EventHandler(this.DetermineDiscountButton_Click);
			// 
			// MovieDiscount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 450);
			this.Controls.Add(this.determineDiscountButton);
			this.Controls.Add(this.discountLabel);
			this.Controls.Add(this.movieRatingTextBox);
			this.Controls.Add(this.movieRatingEntrylabel);
			this.Controls.Add(this.ageTextBox);
			this.Controls.Add(this.ageEntryLabel);
			this.Name = "MovieDiscount";
			this.Text = "Movie Discount";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ageEntryLabel;
		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.Label movieRatingEntrylabel;
		private System.Windows.Forms.TextBox movieRatingTextBox;
		private System.Windows.Forms.Label discountLabel;
		private System.Windows.Forms.Button determineDiscountButton;
	}
}

