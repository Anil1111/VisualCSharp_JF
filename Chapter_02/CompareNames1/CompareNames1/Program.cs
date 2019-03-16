using System;

namespace CompareNames1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Amy";
            string name2 = "Amy";
            string name3 = "Matthew";
            Console.WriteLine("Compare {0} to {1}: {2}", name1, name2, name1 == name2);
            Console.WriteLine("Compare {0} to {1}:  {2}", name1, name3, name1 == name3);
            Console.ReadLine();
        }
    }
}
