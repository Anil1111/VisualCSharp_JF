///Write a GUI program that allows a user to enter scores for
///five tests he has taken.  Display the average of the test scores 
///to two decimal places. Save the project as TestsInteractiveGUI.

using System;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
	public partial class TestAverages : Form
	{
		public TestAverages ( )
		{
			InitializeComponent ( );
		}

		private void Button1_Click (object sender, EventArgs e)
		{
			int test1;
			int test2;
			int test3;
			int test4;
			int test5;
			int totalTest;
			const int TEST = 5;
			double average;
			test1 = Convert.ToInt32(test01.Text);
			test2 = Convert.ToInt32(test02.Text);
			test3 = Convert.ToInt32(test03.Text);
			test4 = Convert.ToInt32(test04.Text);
			test5 = Convert.ToInt32(test05.Text);
			totalTest = test1 + test2 + test3 + test4 + test5;
			average = totalTest / TEST;
			string avg = average.ToString("F2");
			avgScore.Text = "Average Score is " + avg;
		}
	}
}
