using System;

namespace FixDebugTwo1
{
	class Program
	{
		static void Main (string [] args)
		{
			double oneInt = 315.0;
			oneInt = Convert.ToInt32(oneInt);
			double oneDouble = 12.4;
			char oneChar = 'A';
			Console.WriteLine ("The int is {0}", oneInt);
			Console.WriteLine ("The double is {0}", oneDouble);
			Console.WriteLine ("The char is {0}", oneChar);
			Console.ReadLine();
		}
	}
}
