///Write a program for the Magic Blender Company. The program prompts the user for a name,
///street address, city, state, zip code, and quantity of blenders ordered at $39.95 each. 
///In an attractive format (similar to Figure 2-24), display all the input data as well 
///as the following: 
///• Amount due before tax, defined as number ordered times price each 
///• Sales tax, defined as 7% of the amount due
///• Net due, defined as the amount due before tax, plus tax
///Save the program as OrderReceipt.cs.  (Page 101).

using System;

namespace OrderReceipt
{
	class Program
		{
		static void Main (string [] args)
			{
			///Define variables for receipts
			const double TAXES = 0.07;
			const double PRICE = 39.95;
			string name;
			string address;
			string city;
			string state;
			string zipCode;
			int blenders;

			///Get receipt data
			Console.Write("\tORDER RECEIPT" +
				"\nCustomer Name:\t");
			name = Console.ReadLine();
			Console.Write("Address:\t");
			address = Console.ReadLine();
			Console.Write("City:\t\t");
			city =  Console.ReadLine();
			Console.Write("State:\t\t");
			state = Console.ReadLine();
			Console.Write("Zip Code:\t");
			zipCode = Console.ReadLine();
			Console.Write("No# Blenders:\t");
			blenders = Convert.ToInt32(Console.ReadLine());
			
			///Calculate totals for receipt
			double order = PRICE * blenders;
			double tax = order * TAXES;
			double orderTotal = order + tax;
			
			///Convert totals for displaying
			string blenderConversion = blenders.ToString();
			string orderConversion = order.ToString($"C2");
			string taxConversion = tax.ToString ($"C2");
			string orderTotalConversion = orderTotal.ToString ($"C2");

			///Display Receipt
			Console.WriteLine("\tORDER RECEIPT" +
				"\n**********************" +
				"\n{0}" +
				"\n{1}" +
				"\n{2}, {3} {4}" +
				"\nBlenders:\t{5}" +
				"\nSubtotal:\t{6}" + 
				"\nTaxes:\t\t{7}" +
				"\nTotal:\t\t{8}", 
				name, address, city, state, zipCode, blenderConversion, 
				orderConversion, taxConversion, orderTotalConversion);
			Console.ReadLine();
		}
	}
}
