///Create a GUI application that allows the user to enter an hourly pay rate 
///in a TextBox. When the user clicks a button and the value in the TextBox 
///is less than $7.50 or greater than $49.99, display an error message; 
///otherwise, display a message indicating that the rate is okay. Save the 
///project as CheckLowAndHighRateGUI.

using System;
using System.Windows.Forms;

namespace CheckLowAndHighRateGUI
{
	public partial class CheckLowAndHighRateForm : Form
	{
		public CheckLowAndHighRateForm ( )
		{
			InitializeComponent ( );
		}

		private void CheckPayRateButton_Click (object sender, EventArgs e)
		{
			const double MIN_RATE = 7.50;
			const double MAX_RATE = 49.99;
			double hourlyPayRate = Convert.ToDouble(hourlyPayRateTextBox.Text);
			if(hourlyPayRate < MIN_RATE || hourlyPayRate > MAX_RATE)
				resultLabel.Text = "Pay rate is invalid.";
			else
				resultLabel.Text = "Pay rate is valid.";
		}
	}
}
