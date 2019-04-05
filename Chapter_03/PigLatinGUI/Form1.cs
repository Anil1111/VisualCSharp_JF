using System;
using System.Windows.Forms;

namespace PigLatinGUI
{
	public partial class PigLatin : Form
	{
		public PigLatin ( )
		{
			InitializeComponent ( );
		}

		private void PigLatinButton_Click (object sender, EventArgs e)
		{
			string englishWord = englishWordTextBox.Text;
			englishWord = englishWord + englishWord [0];
			englishWord += "ay";
			int pigword = englishWord.Length;
			string pigWord = englishWord.Substring (1, pigword - 1);
			pigWordLabel.Text = "Pig Latin Word is " + pigWord;
		}
	}
}
