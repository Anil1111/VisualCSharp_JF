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
			///Data entry of employee details
			Console.WriteLine ("Weekly Payroll");
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write ("SSN:  ");
			string ssn = Console.ReadLine();
			Console.Write("Hourly Payrate:  ");
			double payrate = Convert.ToDouble (Console.ReadLine ( ));
			Console.Write("Hours Worked:  ");
			int hours = Convert.ToInt32 (Console.ReadLine ( ));
			Console.WriteLine();
			///Calculate withholdings and netpay
			double grosspay = payrate * hours;
			double federal = 0.15 * grosspay;
			double state = 0.05 * grosspay;
			double netPay = grosspay - (federal + state);

			///Strings created to display data in currency format
			string payrateCurrency = payrate.ToString("$#,##0.00");
			string grosspayCurrency = grosspay.ToString("$#,##0.00");
			string federalCurrency = federal.ToString("$#,##0.00");
			string stateCurrency = state.ToString("$#,##0.00");
			string netPayCurrency = netPay.ToString("$#,##0.00");
			Console.WriteLine();

			///Display payroll details
			Console.WriteLine ("Payroll For: \t{0}", name);
			Console.WriteLine ("SSN:  \t\t{0}", ssn);
			Console.WriteLine ("Hours Worked:  \t{0}", hours);
			Console.WriteLine ("Payrate:  \t{0}", payrateCurrency);
			Console.WriteLine ("Gross Pay:  \t{0}", grosspayCurrency);
			Console.WriteLine ("Federal:  \t{0}", federalCurrency);
			Console.WriteLine ("State:  \t{0}", stateCurrency);
			Console.WriteLine ("Net Pay:  \t{0}", netPayCurrency);
            Console.ReadLine();
        }
    }
}
