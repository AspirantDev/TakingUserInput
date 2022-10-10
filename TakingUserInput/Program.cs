using System;

namespace TakingUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int userAge;

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {userName}, You are {userAge} years old.");
        }
    }
}