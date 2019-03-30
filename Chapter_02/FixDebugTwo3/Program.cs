using System;

namespace FixDebugTwo3
{
	class Program
	{
		static void Main (string [] args)
		{
			int a = 99, b = 8, result;
			long c = 7777777777777;
			result = a % b;
			Console.WriteLine("Divide {0} by {1} is {2} ", a, b, (a / b));
			Console.WriteLine("remainder is {0} ", + result);
			Console.WriteLine("c is a very large number: {0} ", c);
			Console.ReadLine();
		}
	}
}
