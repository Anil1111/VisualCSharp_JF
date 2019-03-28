///Create an enumeration named Month that holds values for the months of the year, 
///starting with JANUARY equal to 1. Prompt the user for a month integer. Convert 
///the user’s entry to a Month value and display it. Save the file as MonthNames(Page 102).
using System;

namespace MonthNames
{
	enum Month
	{
		January = 1, Februrary, March, April,
		May, June, July, August, September,
		October, November, December
	}
	class Program
	{
		static void Main (string [] args)
		{
			Console.Write("Enter the numerical month:  ");
			int month = Convert.ToInt32(Console.ReadLine());
			string MonthName = ((Month)month).ToString();
			Console.Write ("Equavalent month is {0}", MonthName);
			Console.ReadLine();
		}
	}

}
