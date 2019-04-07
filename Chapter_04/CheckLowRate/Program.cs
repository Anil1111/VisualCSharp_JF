///Write a console-CheckLowRatebased program that prompts the user for an hourly pay rate. 
///If the value entered is less than $7.50, display an error message. Save the program as 
///CheckLowRate.cs.

using System;

namespace CheckLowRate
{
	class Program
	{
		static void Main (string [] args)
		{
			const double PAY_RATE = 7.50;
			string entryString;
			Console.WriteLine("Enter the hourly pay rate ");
			entryString = Console.ReadLine();
			double hourlyPayRate = Convert.ToDouble(entryString);
			if(hourlyPayRate < PAY_RATE)
				Console.WriteLine("Pay Rate is less than minimum.");
			else
				Console.WriteLine("Minimum Pay Rate is confirmed.");
			Console.ReadLine();
		}
	}
}
