///Write a program that declares variables to represent the length and width of a room in feet and 
///the price of carpeting per square yard in dollars and cents. Assign the value 25 to the length 
///variable and the value 42 to the width variable. Compute and display the cost of carpeting the 
///room. (Hint: Th ere are nine square feet in one square yard.) Save the program as Yards.cs.  (Page 99).

using System;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;
            const int FEET_IN_YARDS = 9;
            int yards = length * width * FEET_IN_YARDS;
            const double PRICE_PER_YARD = 6.89;
            double carpetCost = yards * PRICE_PER_YARD;

            Console.WriteLine("The room has a length of {0} and a width of {1} in square feet.", length, width);
            Console.WriteLine("The square yards of the room is {0}",  yards);
            Console.WriteLine("The cost of a square yard of carpeting is {0}", PRICE_PER_YARD);
            Console.WriteLine("It will cost {0} to supply carpeting for the room.", carpetCost);
            Console.ReadLine();
        }
    }
}
