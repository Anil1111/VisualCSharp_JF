///Write a console-based program that prompts the user for an 
///hourly pay rate and hours worked. Compute gross pay (hours 
///times pay rate), withholding tax, and net pay (gross pay 
///minus withholding tax). Withholding tax is computed as a 
///percentage of gross pay based on the following: Gross Pay 
///Up to and including 300.00 10% 300.01 and up 12% Save the 
///program as Payroll.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
	class Program
	{
		static void Main(string [] args)
		{
			string hoursWorkedEntry;
			string hourlyPayRateEntry;
			int hoursWork;
			double hourlyRate;
			double grossPay;
			double withholding, withholdingRate;
			double netPay;

			Console.Write("Enter hours worked:  ");
			hoursWorkedEntry = Console.ReadLine();
			hoursWork = Convert.ToInt32(hoursWorkedEntry);

			Console.Write("Enter hourly pay rate:  ");
			hourlyPayRateEntry = Console.ReadLine();
			hourlyRate = Convert.ToDouble(hourlyPayRateEntry);

			grossPay = hourlyRate * hoursWork;
			if(grossPay < 301.00)
				withholdingRate = .10;
			else
				withholdingRate = .12;
			withholding = grossPay * withholdingRate;
			netPay = grossPay - withholding;

			string grossPayCurrency = grossPay.ToString("$#,##0.00");
			string withholdingCurrency = withholding.ToString("$#,##0.00");
			string netPayCurrency = netPay.ToString("$#,##0.00");

			Console.WriteLine("PAYROLL SLIP" +
				"\nGross Pay:\t{0}" +
				"\nWithholding:\t{1}" +
				"\nNet Pay:\t{2}", grossPayCurrency, withholdingCurrency, netPayCurrency);
			Console.ReadLine();
		}
	}
}
