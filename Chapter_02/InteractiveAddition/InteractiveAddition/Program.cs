using System;

namespace InteractiveAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, firstString, secondString;
            int first, second, sum;

            Console.Write("Enter your name...");
            name = Console.ReadLine();

            Console.Write("Hello {0}!\nEnter the first integer... ", name);
            firstString = Console.ReadLine();
            first = Convert.ToInt32(firstString);

            Console.Write("Enter the second integer...");
            secondString = Console.ReadLine();
            second = Convert.ToInt32(secondString);

            sum = first + second;
            Console.WriteLine("{0}, the sum of {1} and {2} is {3}.", name, first, second, sum);
            Console.ReadLine();
        }
    }
}
