using System;

namespace DemoEscapeSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This line\tcontains \ttwo tabs");
            Console.WriteLine("This statement\ncontains a new line");
            Console.WriteLine("This statement sounds three alerts\a\a\a");
            Console.ReadLine();

        }
    }
}
