using System;

namespace TestsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TEST = 5;
            int test1, test2, test3, test4, test5;
            Console.WriteLine("Enter a test scoree:  ");
            test1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another test scoree:  ");
            test2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another test scoree:  ");
            test3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another test scoree:  ");
            test4= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter final test scoree:  ");
            test5 = Convert.ToInt32(Console.ReadLine());
            double avgScore = (test1 + test2 + test3 + test4 + test5) / TEST;
            Console.WriteLine("The average score is {0:0.00} avg", avgScore);
            Console.ReadKey();
        }
    }
}
