using System;

namespace JUAN
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Guessing numbers - simple game";
            int appVersion = 1;
            string appAuthor = "Tomasz Górecki";

            Console.WriteLine($"{appName} created by {appAuthor}, version provided:{appVersion}");

            Console.WriteLine("What is your name, my lord?");
            string inputUserName = Console.ReadLine();

            Console.WriteLine($"I wish you luck  { inputUserName}, now it is the time for you to guess the number ... ");
        }
    }

}