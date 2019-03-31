using System;

namespace FixDebugTwo4
{
	class Program
	{
		static void Main (string [] args)
		{
			Console.Write("Enter the price of the item you are buying ");
			string costString = Console.ReadLine();
			double cost = Convert.ToDouble(costString);
			const double TAX = 0.06;
			Console.WriteLine("With a cost of {0} and tax of {1} the final " +
				"purchase price is {2}", cost, TAX, (cost * TAX + cost));
			Console.ReadLine();
		}
	}
}
