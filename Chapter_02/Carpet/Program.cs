///Write a C# program that declares variables to represent the length and width of a room in feet and 
///the price of carpeting per square foot in dollars and cents. Assign appropriate values to the 
///variables. Compute and display, with explanatory text, the cost of carpeting the room. Save the 
///program as Carpet.cs.  (Page 99).

using System;

namespace Carpet
{
   class Program
   {
      static void Main(string[] args)
      {
         int length = 17;
         int witdth = 35;
         int area = length * witdth;
         double costSqft = 2.67;
         double carpetCost = costSqft * area;

         Console.WriteLine("With a length of {0} and a width of {1} the area " +
            " of the room is {2} square feet.", length, witdth, area);
         Console.WriteLine("The cost of the carpetk is {0} per square feet; to " +
            " carpet the room it will cost {1}.", costSqft, carpetCost);
         _ = Console.ReadLine();
      }
   }
}
