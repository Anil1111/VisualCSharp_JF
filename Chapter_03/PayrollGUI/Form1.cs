///Write a GUI program that prompts the user for a name, 
///Social Security number, hourly pay rate, and the number 
///of hours worked. In an attractive format, display all 
///the input data as well as the following: 
///• Gross pay, defined as hourly pay rate times hours worked
///• Federal withholding tax, defined as 15% of the gross pay
///• State withholding tax, defined as 5% of the gross pay
///• Net pay, defined as gross pay minus taxes Save the 
///project as PayrollGUI.

using System;
using System.Windows.Forms;

namespace PayrollGUI
{
	public partial class WeeklyPayroll : Form
	{
		public WeeklyPayroll ( )
		{
			InitializeComponent ( );
		}

		private void ShowPayrollButton_Click (object sender, EventArgs e)
		{
			const double FEDERAL = 0.15;
			const double STATE = 0.05;
			double hoursWorked;
			double payRate;

			payRate = Convert.ToDouble (hourlyPayRateTextBox.Text);
			hoursWorked = Convert.ToDouble(hoursWorkedTextBox.Text);

			double grossPay = payRate * hoursWorked;
			double federalWithholding = grossPay * FEDERAL;
			double stateWithholding = grossPay * STATE;
			double netPay = grossPay - (federalWithholding + stateWithholding);

			ssnShowLabel.Text = "Social Security Number   " + ssn01TextBox.Text + "-" + ssn02TextBox.Text + "-" + ssn03TextBox.Text;
			nameShowLabel.Text = "Name   " + nameTextBox.Text;
			hourlyPayRateShowLabel.Text = "Hourly Pay Rate   " + hourlyPayRateTextBox.Text;
			hoursWorkedShowLabel.Text = "Hours Worked   " + hoursWorkedTextBox.Text;
			grossPayShowLabel.Text = "Gross Pay  " + grossPay;
			federalWithholdingShowLabel.Text = "Federal Withholding   " + federalWithholding;
			stateWithholdingShowLabel.Text = "State Withholding   " + stateWithholding;
			netPayShowLabel.Text = "Net Pay  " + netPay;
		}
	}
}
