using System;

namespace CompareTwoNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Amy";
            string name2 = "Amy";
            string name3 = "Matthew";
            Console.WriteLine("Using Equals() Method");
            Console.WriteLine("Compare {0} to {1}: {2}", name1, name2, String.Equals(name1, name2));
            Console.WriteLine("Compare {0} to {2}: {2}", name1, name3, String.Equals(name1, name3));
            Console.WriteLine();
            Console.WriteLine("Using Compare() Method");
            Console.WriteLine("Compare {0} to {1}:  {2}", name1, name2, String.Compare(name1, name2));
            Console.WriteLine("Compare {0} to {1}:  {2}", name1, name3, String.Compare(name1, name3));
            Console.WriteLine();
            Console.WriteLine("Using CompareTo() Method");
            Console.WriteLine("Compare {0} to {1}:  {2}", name1, name2, name1.CompareTo(name2));
            Console.WriteLine("Compare {0} to {1}:  {2}", name1, name3, name1.CompareTo(name3));
            Console.ReadLine();


        }
    }
}
