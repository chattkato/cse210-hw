using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";
        
        // Stretch Challenge 2: Loop to play again
        while (playAgain.ToLower() == "yes" || playAgain.ToLower() == "y")
        {
            // Core Requirement 3: Generate random number from 1 to 100
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int guessCount = 0;
            
            Console.WriteLine("\nI've picked a magic number between 1 and 100. Try to guess it!");
            
            // Core Requirement 2: Keep looping until guess is correct
            while (guess != magicNumber)
            {
                // Get user's guess with input validation
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                
                // Validate input
                if (int.TryParse(input, out guess))
                {
                    guessCount++;
                    
                    // Core Requirement 1: Determine if guess is higher, lower, or correct
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        // Stretch Challenge 1: Inform user of total guesses
                        Console.WriteLine($"It took you {guessCount} guesses!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            
            // Stretch Challenge 2: Ask if user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
            
            // Handle empty input
            if (string.IsNullOrEmpty(playAgain))
            {
                playAgain = "no";
            }
        }
        
        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}