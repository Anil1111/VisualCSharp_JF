///Write a console-based program that prompts a user for an hourly pay rate. 
///If the user enters values less than $7.50 or greater than $49.99, prompt the 
///user again. If the user enters an invalid value again, display an appropriate 
///error message. If the user enters a valid value on either the first or second 
///attempt, display the pay rate as well as the weekly rate, which is calculated 
///as 40 times the hourly rate. Save the program as SecondChancePayRate.cs.

using System;

namespace SecondChancePayRate
{
	class Program
	{
		static void Main (string [] args)
		{
			const double MIN_RATE = 7.50;
			const double MAX_RATE = 49.99;
			const int HOURS = 40; 
			string rateEntry;
			double weeklyWage;
			int count = 0;
			Console.Write("Enter hourly pay rate");
			rateEntry = Console.ReadLine();
			count++;
			double hourlyWage = Convert.ToDouble(rateEntry);
			if (count < 2)
				if(hourlyWage < MIN_RATE || hourlyWage > MAX_RATE);
					Console.Write("Invalid entry, re-enter hourly wage");
			count++;
			rateEntry = Console.ReadLine();
			hourlyWage = Convert.ToDouble(rateEntry);
			weeklyWage = HOURS * hourlyWage;
			Console.WriteLine("Weekly wage is {0}, and hourly rate is {1}", weeklyWage, hourlyWage);
			Console.ReadLine();
		}
	}
}
