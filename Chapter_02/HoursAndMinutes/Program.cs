///Write a program that declares a minute variable to represent minutes worked on a job,
///and assign a value to it. Display the value in hours and minutes. For example, 197 
///minutes becomes 3 hours and 17 minutes. Save the program as HoursAndMinutes.cs.  (Page 99).

using System;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int HOURS = 60;
            int minutes = 4865;
            int hoursWorked = minutes / HOURS;
            int minutesWorked = minutes % HOURS;
            Console.WriteLine("The total minutes worked are {0}.", minutes);
            Console.WriteLine("This calculates to {0} hours and {1} minutes.", hoursWorked, minutesWorked);
            Console.ReadLine();
        }
    }
}
