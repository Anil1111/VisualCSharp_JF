using System;

namespace MovieDiscount
{
	class Program
	{
		static void Main (string [] args)
		{
			int age = 75;
			char rating = 'G';
			const int CHILD_AGE = 12;
			const int SENIOR_AGE = 65;
			Console.WriteLine("When age is {0} and rating is {1} ", age, rating);
			if((age <= CHILD_AGE || age >= SENIOR_AGE) && rating == 'G')
				Console.WriteLine("Discount Applies");
			else
				Console.WriteLine("Full Price");
			Console.ReadLine();
		}
	}
}
