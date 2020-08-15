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

            ShowAppInfo();  // Display app intro

            GreetUser();


            while (true)
            {
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
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");
                        continue;
                    }

                    // Cast to int
                    guess = Int32.Parse(input);

                    // Check the guess
                    if (guess != correctNumber)
                    {
                        // Print wrong guess message
                        PrintColorMessage(ConsoleColor.Red, "Sorry, try again!");

                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!");

                // Ask to play agin
                Console.WriteLine("Play Again? [Y/N]");

                // Get answer regardles of case 
                string answer = Console.ReadLine().ToUpper();

                // User must explicitly exit or the next round starts
                if (answer == "N" || answer == "NO")
                {
                    return;
                }
                continue;
            }
        }

        // Displays app info
        static void ShowAppInfo() {
            // Some application variables
            string appName = "Simple Number Guesser";
            string appVersion = "1.0.0";

            PrintColorMessage(ConsoleColor.Green, $"{appName}: Version {appVersion}");
        }

        // Get the user name and greet them
        static void GreetUser() {
            Console.WriteLine("What is your name:");
            string inputName = Console.ReadLine();
            Console.WriteLine($"Hello {inputName}, let's play a game...");
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
