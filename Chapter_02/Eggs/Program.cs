///Write a program that declares four variables to hold the number of eggs produced 
///in a month by each of four chickens, and assign a value to each variable. Sum the 
///eggs, then display the total in dozens and eggs. For example, a total of 127 eggs 
///is 10 dozen and 7 eggs. Save the program as Eggs.cs.  (Page 100).

using System;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = 546;
            const int CHICENS = 12;
            int dozes = eggs / CHICENS;
            int singles = eggs % CHICENS;
            Console.WriteLine("There are {0} dozen and {1} single egge.", dozes, singles);
            Console.ReadLine();
        }
    }
}
