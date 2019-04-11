///Create a GUI application similar to the one described in Exercise 3a. Allow the 
///user to click a button to submit a rate. After the user has made a valid entry,
///or after two invalid entries, make the button invisible. Save the project as 
///SecondChancePayRateGUI

using System;
using System.Windows.Forms;

namespace SecondChancePayRateGUI
{
	public partial class SecondChancePayRate : Form
	{
		public SecondChancePayRate()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			const double MIN_WAGE = 7.50;
			const double MAX_WAGE = 49.99;
			int count = 0;
			double hourlyPayRate = Convert.ToDouble(hourlyPayRateTextBox.Text);

			if ((count < 2 ) && (hourlyPayRate < MIN_WAGE) || ( hourlyPayRate > MAX_WAGE ))
					{
						payRateResultlabel.Text = "Hourly Wage is Invalid.  " +
							"Please Enter another value";
						count++;
					}
			else if (( count < 2 ) && ( hourlyPayRate > MIN_WAGE ) && ( hourlyPayRate < MAX_WAGE ))
					{
						payRateResultlabel.Text = "Hourly Wage is Valid";
						checkPayRateButton.Enabled = false;
						count++;
					}
			else if (( count >= 2 ) && ( hourlyPayRate < MIN_WAGE ) || ( hourlyPayRate > MAX_WAGE ))
				{
						payRateResultlabel.Text = "Hourly Wage is Invalid";
						checkPayRateButton.Enabled = false;
				}
		}
	}
}
