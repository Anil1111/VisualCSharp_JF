﻿using System;

namespace NestedDecision
{
	class Program
	{
		static void Main (string [] args)
		{
			const int HIGH = 10, LOW = 5;
			string numberString;
			int number;
			Console.Write("Enter an integer  ");
			numberString = Console.ReadLine();
			number = Convert.ToInt32 (numberString);
			if(number > LOW)
				if(number < HIGH)
					Console.WriteLine("{0} is between {1} and {2}", number, LOW, HIGH);
			Console.ReadLine();
		}
	}
}
