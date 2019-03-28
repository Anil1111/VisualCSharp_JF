///Pig Latin is a nonsense language. To create a word in pig Latin, you remove the first 
///letter and then add the first letter and “ay” at the end of the word. For example, 
///“dog” becomes “ogday” and “cat” becomes “atcay”. Write a program that allows the 
///user to enter a word. Output the pig Latin version. Save the file as PigLatin(Page 102).

using System;

namespace PigLatin
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter any word:  ");
			String englishWord = Console.ReadLine();
			englishWord = englishWord + englishWord[0];
			englishWord += "ay";
			int pigword = englishWord.Length;
			string pigWord = englishWord.Substring(1, pigword - 1);
			Console.WriteLine("The new word is {0}", pigWord);
			Console.ReadLine();
		}
	}
}
