using System;

namespace BooleanExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valueA, valueB, valueC;
            bool valueD, valueE, valueF;
            bool valueG, valueH, valueI;
            bool valueJ;

            int a, b, c, d;

            a = 5;
            b = 2;
            valueA = a > b;
            Console.WriteLine("A.  Boolean valueA is {0} > {1} which is {2}", a, b, valueA);
            a = 6;
            b = 18;
            valueB = a <= b;
            Console.WriteLine("B.  Boolean valueB is {0} <= {1} which is {2}", a, b, valueB);
            a = 49;
            b = 49;
            valueC = a >= b;
            Console.WriteLine("C.  Boolean valueC is {0} >= {1} which is {2}", a, b, valueC);
            a = 2;
            b = 3;
            valueD = 2 == 3;
            Console.WriteLine("D.  Boolean valueD is {0} >= {1} which is {2}", a, b, valueD);
            b = 6;
            c = 7;
            valueE = 2 + 6 == 7;
            Console.WriteLine("E.  Boolean valueE is {0} >= {1} which is {2}", a, b, valueE);
            a = 3;
            b = c;
            c = 10;
            valueF = a + b <= c;
            Console.WriteLine("f.  Boolean valueF is {0} + [1] <= {2} which is {3}", a, b, c, valueF);
            a = 3;
            b = 9;
            valueG = a != 9;
            Console.WriteLine("g.  Boolean valueG is {0} != {1} which is {2}", a, b, valueG);
            a = 12;
            b = 12;
            valueH = a != b;
            Console.WriteLine("H.  Boolean valueH is {0} != {1} which is {2}", a, b, valueH);
            a = 2;
            b = 2;
            valueI = a != b;
            Console.WriteLine("I.  Boolean valueI is {0} != {1} which is {2}", a, b, valueI);
            b = 5;
            c = 3;
            d = 21;
            valueJ = a + b * c == d;
            Console.WriteLine("J.  Boolean valueJ is {0} + {1} * {2} == {3} which is {4}", a, b, c, d, valueJ);
            Console.ReadLine();

        }
    }
}
