﻿using System;

namespace InteractiveSalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.06;
            string itemPriceAsString;
            double itemPrice;
            double total;
            Console.Write("Enter the price of an item >>");
            itemPriceAsString = Console.ReadLine();
            itemPrice = Convert.ToDouble(itemPriceAsString);
            total = itemPrice * TAX_RATE;
            Console.WriteLine("With a tax rate of {0}, a {1} item cost {2} more.", 
                TAX_RATE, itemPrice.ToString("C2"), total.ToString("C2"));
            Console.ReadLine();
        }
    }
}
