///Write a console-based program that prompts a user for an hourly pay rate. 
///If the value entered is less than $7.50 or greater than $49.99, display 
///an error message; otherwise, display a message indicating that the rate 
///is okay. Save the program as CheckLowAndHighRate.cs.

using System;

namespace CheckLowAndHighRate
{
	class Program
	{
		static void Main (string [] args)
		{
			const double MIN_RATE = 7.50;
			const double MAX_RATE = 49.99;
			Console.Write("Enter the hourly pay rate:  ");
			string payRate = Console.ReadLine();
			double hourlyPayRate = Convert.ToDouble(payRate);
			if(hourlyPayRate < MIN_RATE || hourlyPayRate > MAX_RATE)
				Console.WriteLine("Pay rate is invalid");
			else
				Console.WriteLine("Pay rate is valid.");
			Console.ReadLine();
		}
	}
}
