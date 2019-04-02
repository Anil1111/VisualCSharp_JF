///Write a GUI program that accepts the names of two of your friends. 
///Display the result of using the String.Compare() method with your 
///friends’ names. Save the project as TwoFriendsInteractiveGUI.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFriendsInteractiveGUI
{
	public partial class FriendsCompare : Form
	{
		public FriendsCompare ( )
		{
			InitializeComponent ( );
		}

		private void CompareNames_Click (object sender, EventArgs e)
		{
			string firstFriend;
			string secondFriend;
			firstFriend = friend01Name.Text;
			secondFriend = friend02Name.Text;
			firstToSecond.Text = "Comparing " + firstFriend + " and " + secondFriend + " is " + firstFriend.CompareTo(secondFriend);
		}
	}
}
