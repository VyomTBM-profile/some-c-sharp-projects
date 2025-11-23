using System;
using System.Threading;

namespace ConsoleRandGame
{
    class Program 
    {
        static void Main() 
        {
            Console.WriteLine("Welcome to ConsoleRandGame. Guess a number between 1 and 10");
            var rand = new Random();
            int number = rand.Next(1, 10); // Makes the number to guess
            Thread.Sleep(2000);
            string inputnumber = Console.ReadLine();
            int input = int.Parse(inputnumber);
            if (input == number)
            {
                Console.WriteLine("You guessed the number");
                return;
            }
            else
            {
                Console.WriteLine("You did not guess the number. You lose");
                Console.WriteLine("The number was " + number);
                return;
            }
        }
    }
}
