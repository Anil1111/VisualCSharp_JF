///Write a console-based program that accepts a user’s message and determines whether
///it is short enough for a social networking service that does not accept messages 
///of more than 140 characters. Save the program as Twitter.cs.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
	class Program
	{
		static void Main(string [] args)
		{
			int characters; 
			string message;
			Console.Write("Enter your message");
			message = Console.ReadLine();
			characters = message.Length;
			if(characters > 140)
				Console.WriteLine("Message is too long.");
			else
				Console.WriteLine("Message is valid.");
			Console.ReadLine();

		}
	}
}
