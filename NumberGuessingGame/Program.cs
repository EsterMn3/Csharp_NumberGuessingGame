using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!\nYou have 5 chances to win this game.");

            Random random = new Random();
            int secretNumber = random.Next(1, 101); //the random number is stored in this variable
            int guess;//the number that the user guesses
            int guessCount = 0; //this variale stores how many times the user has guessed
            bool correctGuess = false;
            int maxGuesses = 5; //5 chances

            while (!correctGuess && guessCount < maxGuesses)
            {
                Console.Write("Enter your guess (1-100): ");
                try//in case the user doesnt give a number we have to tell them
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                        continue;
                    }

                    guessCount++;

                    if (guess == secretNumber)
                    {
                        Console.WriteLine("Congratulations! You guessed the correct number!");
                        correctGuess = true;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number between 1 and 100.");
                }
            }

            if (!correctGuess)
            {
                Console.WriteLine($"Sorry, you've run out of guesses. The secret number was {secretNumber}.");
            }
        }
    }
}
