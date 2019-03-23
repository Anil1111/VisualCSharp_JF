///Modify the TwoFriends program in Exercise 14 so it accepts your friends’ 
///names from the keyboard. Save the program as TwoFriendsInteractive.cs.

using System;

namespace TwoFriendsINteracive
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your friendss first name -->");
            string firstFriend = Console.ReadLine();
            Console.WriteLine("Enter another friends first name -->");
            string secondFriend = Console.ReadLine();
            Console.WriteLine("Compare {0} to {1}: {2}", firstFriend, secondFriend, firstFriend.CompareTo(secondFriend));
            Console.ReadLine();
        }
    }
}
