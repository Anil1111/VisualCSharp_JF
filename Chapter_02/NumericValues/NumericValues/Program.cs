using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;
            int valueA, valueB, valueC, valueD;
            int valueE, valueF, valueG, valueH;
            int valueI;
            first = 4;
            second = 2;
            third = 3;
            valueA = first + second * third;
            Console.WriteLine("A.  {0} + {1} * {2} = {3}", first, second, third, valueA);
            first = 6;
            second = 4;
            third = 7;
            valueB = first / second * third;
            Console.WriteLine("B. {0} / {1} * {2} = {3}", first, second, third, valueB);
            first = 16;
            second = 2;
            third = 14;
            valueC = first / second + third / second;
            Console.WriteLine("C.  {0} / {1} + {2} / {3} = ", first, second, third, second, valueC);
            first = 18;
            valueD = first / second;
            Console.WriteLine("D.  {0} / {1} = {2}", first, second, valueD);
            first = 17;
            valueE = first / second;
            Console.WriteLine("E.  {0} / {1} = {2}", first, second, valueE);
            first = 32;
            second = 5;
            valueF = first / second;
            Console.WriteLine("F.  {0} / {1} = {2}", first, second, valueF);
            first = 14;
            second = 2;
            valueG = first % second;
            Console.WriteLine("G. {0} % {1} = {2}", first, second, valueG);
            first = 15;
            valueH = first % second;
            Console.WriteLine("H. {0} % {1} = {2}", first, second, valueH);
            first = 28;
            second = 5;
            valueI = first % second;
            Console.WriteLine("I. {0} % {1} = {2}", first, second, valueI);
            Console.ReadLine();
        }
    }
}
