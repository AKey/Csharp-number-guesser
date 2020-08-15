using System;
using System.Dynamic;

namespace CsNumberGuesser
{
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // START HERE //
            Console.WriteLine("What is your name:");

            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");

            // Create a new Random object
            Random random = new Random();

            // Use the Random object to generate a correct number
            int correctNumber = random.Next(1, 10);

            // Init guess var
            int guess = 0;

            // Ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            // While the guess is not correct. Our main loop
            while (guess != correctNumber)
            {
                // Get user input
                string input = Console.ReadLine();

                // Ohh, simple input validation
                if (!int.TryParse(input, out guess))
                {
                    // Tell the user they need to enter a number
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a whole number");
                    Console.ResetColor();
                    continue;
                }

                // Cast to int
                guess = Int32.Parse(input);

                // Check the guess
                if (guess != correctNumber)
                {
                    // Alert user they guessed wrong
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That's not the right number. Try again.");
                    Console.ResetColor();

                }
            }

            // Output success message
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Correct!");
            Console.ResetColor();
        }
    }
}
