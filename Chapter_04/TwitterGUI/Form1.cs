///Create a GUI application similar to Exercise 4a. 
///Save the project as TwitterGUI.

using System;
using System.Windows.Forms;

namespace TwitterGUI
{
	public partial class TwitterForm : Form
	{
		public TwitterForm()
		{
			InitializeComponent();
		}

		private void SendMessageButton_Click(object sender, EventArgs e)
		{
			const int WORD_COUNT = 140;
			int text = messageTextBox.Text.Length;
			if(text > WORD_COUNT)
				messageSentLabel.Text = "Message is too long; \nshorten message and resend.";
			else
			{
				messageSentLabel.Text = "Message sent.";
				sendMessageButton.Enabled = false;
			}
				
		}
	}
}
