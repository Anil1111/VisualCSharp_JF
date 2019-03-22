///Modify the Eggs program in Exercise 10 so it prompts the user for and 
///accepts a number of eggs for each chicken. Save the program as 
///EggsInteractive.cs.  (Page 100).

using System;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DOZEN = 12;
           
            Console.WriteLine("How many eggs would you like?");
            int eggs = Convert.ToInt32(Console.ReadLine());

            int dozenEggs = eggs / DOZEN;
            int singleEggs = eggs % DOZEN;
            Console.WriteLine("A total of {0} eggs are required.", eggs);
            Console.WriteLine("This calculates to {0} dozen with a remainding {1} single eggs.", dozenEggs, singleEggs);
            Console.ReadLine();
        }
    }
}
