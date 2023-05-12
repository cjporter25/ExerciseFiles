using System;
using System.Globalization;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int guessCount = 0;      // Increment each guess  
            int userGuess = -2;    // Initialize integer placeholder for input

            do {
                Console.WriteLine("What's your guess?");
                // Initialize string variable to hold input
                string userInput = Console.ReadLine(); 
                // Save the result of comparing user input to
                //     the actual number
                bool correct = Int32.TryParse(userInput, out userGuess);
                if (!correct) {
                    Console.WriteLine("Hmmm, that doesn't look like a number. Try again.");
                } else if (userGuess == -1) {
                    Console.WriteLine($"Oh well. I was thinking of {theNumber}");
                    break;
                } else if (userGuess == theNumber) {
                    break;
                } else {
                    // Output standard statement, however, add a qualifier that checks for
                    //  whether the guess is higher or lower. Add the word "higher" or "lower"
                    //  depending on which on it is.
                    Console.WriteLine("Nope, {0} than that.", userGuess < theNumber ? "higher" : "lower");
                }
                // else if (userGuess > theNumber) {
                //     Console.WriteLine("Nope, lower than that.");
                // } else if (userGuess < theNumber) {
                //     Console.WriteLine("Nope, higher than that.");
                // }
                guessCount++;

            } while (userGuess != theNumber);
                Console.WriteLine($"You got it in {guessCount} guesses!!");



            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            
        }
    }
}
