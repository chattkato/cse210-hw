// Creativity Addition
// I added a "mood" field to every journal entry so the user can record
// how they felt during the day. This helps users reflect emotionally
// and makes the journal more meaningful than just recording events.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Console.Write("What was your mood today? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }
        }
    }
}
