using System;

namespace Legal_Illegal
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b, c;

            double valueA, valueB, valueC, valueD, valueE;

            b = 2.2;
            c = 1.4;
            valueA = b * c;
            Console.WriteLine("A. {0} * {1} = {2}.", b, c, valueA);
            a = 2;
            b = 6.78;
            valueB = b - a;
            Console.WriteLine("B.  {0} - {1} = {2}", b, a, valueB);
            b = 24.0;
            c = 6.0;
            valueC = b / c;
            Console.WriteLine("C  {0} / {1} = {2}", b, c, valueC);
            b = 7.0;
            c = 3.0;
            valueD = b % c;
            Console.WriteLine("D.  {0} % {1} = {2}", b, c, valueD);
            a = 9;
            b = 2.0;
            valueE = a % b;
            Console.WriteLine("E.  {0} % {1} = {2}", a, b, valueE);
            Console.ReadLine();
        }
    }
}
