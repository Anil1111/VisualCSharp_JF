///Create an enumeration named Month that holds values for the months of 
///the year, starting with JANUARY equal to 1. (Recall that an enumeration
///must be placed within a class but outside of any method.) Using a GUI
///interface, prompt the user for a month integer. Convert the user’s 
///entry to a Month value and display it. Save the project as MonthNamesGUI

using System;
using System.Windows.Forms;

namespace MonthNamesGUI
{
	public partial class MonthNames : Form
	{
		enum Month
			{
				January = 1, February, March,
				April, May, June, July, 
				August, September, October,
				November, December
			}

		public MonthNames ( )
		{
			InitializeComponent ( );
		}

		private void MonthTextBox_TextChanged (object sender, EventArgs e)
		{
			int month;
			month = Convert.ToInt32(monthTextBox.Text);
			string monthName = ((Month)month).ToString();
			monthSelectedLabel.Text = "Month Selected is " + monthName;
		}
	}
}


