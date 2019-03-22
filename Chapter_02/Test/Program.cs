using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TEST = 5;
            int test1 = 65;
            int test2 = 78;
            int test3 = 99;
            int test4 = 100;
            int test5 = 98;
            double avgScore = (test1 + test2 + test3 + test4 + test5) / TEST;
            Console.WriteLine("The average score is {0:0.00} avg", avgScore);
            Console.ReadKey();
        }
    }
}
