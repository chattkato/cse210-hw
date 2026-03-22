// EXCEEDING REQUIREMENTS
// This program goes beyond the basic expectations in several ways.
//
// First, it hides multiple words at a time and only selects words that are still visible.
// This improves the memorization process and avoids repetition.
//
// Second, the program automatically ends when all words are hidden,
// allowing the user to clearly know when the exercise is complete.
//
// Third, the program loads scriptures from an external file and stores them
// in a collection. A random scripture is selected each time the program runs,
// which provides variety and makes the program more useful.
//
// Fourth, the program is organized into separate classes with clear responsibilities,
// making it easier to understand and extend in the future.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

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

    static List<Scripture> LoadScriptures(string fileName)
    {
        List<Scripture> scriptures = new List<Scripture>();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);

            if (parts.Length == 5)
            {
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                Reference reference = new Reference(book, chapter, verse, endVerse);
                scriptures.Add(new Scripture(reference, text));
            }
            else
            {
                string text = parts[3];

                Reference reference = new Reference(book, chapter, verse);
                scriptures.Add(new Scripture(reference, text));
            }
        }

        return scriptures;
    }
}