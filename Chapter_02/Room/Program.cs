//Write a C# program that declares variables to represent the length and width of a room in feet.
//Assign appropriate values to the variables, such as length = 15 and width = 25. Compute and display
//the floor space of the room in square feet (area = length * width). As output, do not display only 
//a value; instead, display explanatory text with the value, such as The floor space is 375 square 
//feet. Save the program as Room.cs.  (Page 99).

using System;

namespace Room
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 17;
            int width = 35;
            int area = length * width;
            Console.WriteLine("With a room {0} feet long and {1} feet wide" +
                " the total area of the room is {2} square feet.", length, width, area);
         _ = Console.ReadLine();
        }
    }
}
