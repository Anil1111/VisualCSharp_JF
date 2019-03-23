///Write a program that declares two variables to hold the names of two of 
///your friends, and assign a value to each variable. Display the result of
///using the String.Compare() method with your friends’ names. Save the 
///program as TwoFriends.cs.  (Page 100).

using System;

namespace TwoFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFriend = "Felicia";
            string secondFriend = "Arthur";
            Console.WriteLine("Compare {0} to {1}: {2}", firstFriend, secondFriend, firstFriend.CompareTo(secondFriend));
            Console.ReadLine();
        }
    }
}
