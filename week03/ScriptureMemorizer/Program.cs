// EXCEEDING REQUIREMENTS
// This program goes beyond the basic expectations in several ways.
//
// First, it hides more than one word at a time. Instead of removing a single word,
// it removes three words during each step. This makes the memorization process
// more engaging and helps the user learn faster.
//
// Second, the program keeps track of when all the words have been hidden.
// Once this happens, it ends automatically. This allows the user to know
// when they have completed the exercise without any confusion.
//
// Third, the program is carefully organized using separate classes such as
// Reference, Word, and Scripture. Each class has its own responsibility,
// which makes the code easier to understand and manage.
//
// Finally, the overall structure of the program makes it easy to improve in the future.
// For example, more scriptures could be added or loaded from a file without needing
// to change the main logic of the program.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference,
        "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths");

        string input = "";

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type quit to exit.");
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden. Program finished.");
    }
}
