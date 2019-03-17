using System;

namespace DemoVariables2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 43, value2 = 10, sum, diff, product, quotient, remainder;

            sum = value1 + value2;
            diff = value1 - value2;
            product = value1 * value2;
            quotient = value1 / value2;
            remainder = value2 % value2;

            Console.WriteLine("The sum of {0} and {1} is {2}.", value1, value2, sum);
            Console.WriteLine("The difference between {0} and {1} is {2}.", value1, value2, diff);
            Console.WriteLine("The product of {0} and {1} is {2}.", value1, value2, product);
            Console.WriteLine("{0} divide by {1} is {2}.", value1, value2, quotient);
            Console.WriteLine("with a remainder of {0}.", remainder);
            Console.ReadLine();
        }
    }
}
