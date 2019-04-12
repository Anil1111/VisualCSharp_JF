///Create a GUI application for the college admissions offi ce described
///in Exercise 5a. Save the project as AdmissionGUI.

using System;
using System.Windows.Forms;

namespace AdmissionGUI
{
	public partial class CollegeAdmissionForm : Form
	{
		public CollegeAdmissionForm()
		{
			InitializeComponent();
		}

		private void RequirementsButton_Click(object sender, EventArgs e)
		{
			const double GPA_MIN = 2.9;
			const double GPA_MAX = 3.0;
			const int TEST_MIN = 59;
			const int TEST_MAX = 79;
			string gpaEntry = gpaTextBox.Text;
			string testEntry = testScoreTextBox.Text;
			double gpa = Convert.ToDouble(gpaEntry);
			int test = Convert.ToInt32(testEntry);
			if(gpa > GPA_MIN)
				if(test > TEST_MIN)
				{
					adminResultLabel.Text = "Student Accepted";
					requirementsButton.Enabled = false;
				}
			if(gpa < GPA_MAX)
				if(test > TEST_MAX)
				{
					adminResultLabel.Text = "Student Accepted";
					requirementsButton.Enabled = false;
				}
			else
				{
					adminResultLabel.Text = "Student Rejected";
					requirementsButton.Enabled = false;
				}
		}
	}
}
