using System;

namespace TakingUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {userName}, You are {userAge} years old.");
        }
    }
}