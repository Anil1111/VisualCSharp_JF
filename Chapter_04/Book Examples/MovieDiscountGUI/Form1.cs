using System;
using System.Windows.Forms;

namespace MovieDiscountGUI
{
	public partial class MovieDiscount : Form
	{
		public MovieDiscount ( )
		{
			InitializeComponent ( );
		}

		private void DetermineDiscountButton_Click (object sender, EventArgs e)
		{
			int age;
			char rating;
			const int CHILD_AGE = 12;
			const int SENIOR_AGE = 65;
			age = Convert.ToInt32(ageTextBox.Text);
			rating = Convert.ToChar(movieRatingTextBox.Text);
			discountLabel.Text = String.Format("When age is {0} and rating is {1}", age, rating);
			if((age <= CHILD_AGE || age >= SENIOR_AGE) && rating == 'G')
				discountLabel.Text += "\nDiscount applies";
			else
				discountLabel.Text += "\nFull price";
		}
	}
}
