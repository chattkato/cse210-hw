using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";
        
        
        while (playAgain.ToLower() == "yes" || playAgain.ToLower() == "y")
        {
            
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int guessCount = 0;
            
            Console.WriteLine("\nI've picked a magic number between 1 and 100. Try to guess it!");
            
           
            while (guess != magicNumber)
            {
                
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                
                
                if (int.TryParse(input, out guess))
                {
                    guessCount++;
                    
                   
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
                    
                        Console.WriteLine($"It took you {guessCount} guesses!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            
            
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
            
            
            if (string.IsNullOrEmpty(playAgain))
            {
                playAgain = "no";
            }
        }
        
        Console.WriteLine("Thanks for playing! Goodbye!");
    }
 }