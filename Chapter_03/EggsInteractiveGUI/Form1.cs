using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
	public partial class eggProduction : Form
	{
		public eggProduction ( )
		{
			InitializeComponent ( );
		}

		private void Button1_Click (object sender, EventArgs e)
		{
			int egg01;
			int egg02;
			int egg03;
			int egg04;
			int egg05;
			egg01 = Convert.ToInt32(textBox1.Text);
			egg02 = Convert.ToInt32(textBox2.Text);
			egg03 = Convert.ToInt32(textBox3.Text);
			egg04 = Convert.ToInt32(textBox4.Text);
			egg05 = Convert.ToInt32(textBox5.Text);
			int addEggs = egg01 + egg02 + egg03 + egg04 + egg05;
			totalEggs.Text = "Total Eggs are " + addEggs;
		}
	}
}
