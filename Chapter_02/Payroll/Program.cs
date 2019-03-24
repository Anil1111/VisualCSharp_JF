///Write a program that prompts the user for a name, Social Security number,
///hourly pay rate, and the number of hours worked. In an attractive format 
///(similar to Figure 2-23), display all the input data as well as the following: 
///• Gross pay, defined as hourly pay rate times hours worked
///• Federal withholding tax, defined as 15% of the gross pay
///• State withholding tax, defined as 5% of the gross pay
///• Net pay, defined as gross pay minus taxes
///• Save the program as Payroll.cs.

using System;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the following information when prompted\n" +
            "Name, Social Security Number, Hourly Pay Rate\n" +
            "number hours worked");
            Console.Write("Name:  ");
            String name = Console.ReadLine();
            Console.Write("SSN First Three Digits:  ");
            String ssn1 = Console.ReadLine();
            Console.Write("SSN Two Middle Digits:  ");
            String ssn2 = Console.ReadLine();
            Console.Write("SSN Last Four Digits:  ");
            String ssn3 = Console.ReadLine();
            Console.Write("Hourly Pay Rate:  ");
            double hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours Worked:  ");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());
            double grossPay = hourlyPayRate * hoursWorked;

            string ssn = (ssn1 + "-" + ssn2 + "-" + ssn3);
            string gpConverdion = grossPay.ToString("C2");
            string hprConveerion = hourlyPayRate.ToString("C2");
            Console.WriteLine("\tPAYROLL EARNINGS\n" +
                "\nName:\t\t\t{0}" +
                "\nSSN:\t\t\t{1}" +
                "\nHourly Pay Rate\t\t{2} " +
                "\nHours Worked:\t\t{3} " +
                "\nGross Pay\t\t{4}", name, ssn, hprConveerion, hoursWorked, gpConverdion);
            Console.ReadLine();
        }
    }
}
