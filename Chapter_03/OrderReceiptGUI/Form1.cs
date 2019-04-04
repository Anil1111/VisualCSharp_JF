///Write a GUI program for the Magic Blender Company. The program prompts 
///the user for a name, street address, city, state, zip code, and quantity 
///of blenders ordered at $39.95 each. Display all the input data as well 
///as the following:
///• Amount due before tax, defined as number ordered times price each 
///• Sales tax, defined as 7% of the amount due
///• Net due, defined as the amount due before tax, plus tax Save the 
///project as OrderReceiptGUI.

using System;
using System.Windows.Forms;

namespace OrderReceiptGUI
{
	public partial class OrderReceipt : Form
	{
		public OrderReceipt ( )
		{
			InitializeComponent ( );
		}

		private void OrderButton_Click (object sender, EventArgs e)
		{
			const double SALES_TAX = 0.07;
			const double BLENDER = 39.95;

			string name, address, city, state, zipcode;
			int blenderOrder = Convert.ToInt32(blendersTextBox.Text);
			double orderTotal = BLENDER * blenderOrder;
			double salesTax= orderTotal * SALES_TAX;
			double receipt = orderTotal + salesTax;

			name = nameTextBox.Text;
			address = addressTextBox.Text;
			city = cityTextBox.Text;
			state = stateTextBox.Text;
			zipcode = zipCodeTextBox.Text;

			nameShowLabel.Text = "Name  " + name;
			addressShowLabel.Text = "Address  " + address;
			cityShowLabel.Text = "City  " + city;
			stateShowLabel.Text = "State  " + state;
			zipShowLabel.Text = "Zip Code  " + zipcode;
			orderShowLabel.Text = "Blenders Ordered  " + blenderOrder;
			orderTotalShowLabel.Text = "Order Total  " + orderTotal;
			salesTaxShowLabel.Text = "Sales Tax  " + salesTax;
			totalShowLabel.Text  = "Order Total  " + receipt;
		}
	}
}
