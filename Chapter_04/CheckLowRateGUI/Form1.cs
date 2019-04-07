///Create a GUI application that allows the user to enter an hourly pay 
///rate in a TextBox. When the user clicks a button and the value in the
///TextBox is less than $7.50, display an error message. Save the project
///as CheckLowRateGUI.

using System;
using System.Windows.Forms;

namespace CheckLowRateGUI
{
	public partial class CheckLowRate : Form
	{
		public CheckLowRate ( )
		{
			InitializeComponent ( );
		}

		private void CheckMinWageButton_Click (object sender, EventArgs e)
		{
			const double MIN_WAGE = 7.50;
			double wage = Convert.ToDouble(hourlyPayRateTextBox.Text);
			if(wage < MIN_WAGE)
				minimumWageLabel.Text = "Pay rate is less than minimum wage.";
			else
				minimumWageLabel.Text = "Pay rate meets minimum wage.";
		}
	}
}
