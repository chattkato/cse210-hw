using System;
using System.IO;

class Program
{
    static int breathingCount = 0;
    static int reflectionCount = 0;
    static int listingCount = 0;

    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // 1. Tracks how many times each activity is performed.
        // 2. Saves activity log to a file (log.txt).
        // 3. Ensures prompts are not repeated until all are used.
        // 4. Improved breathing animation with inhale, hold, exhale pattern.

        int choice = 0;

        while (choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Save Log");
            Console.WriteLine("5. Quit");

            Console.Write("\nChoose: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new BreathingActivity().Run();
                    breathingCount++;
                    break;

                case 2:
                    new ReflectionActivity().Run();
                    reflectionCount++;
                    break;

                case 3:
                    new ListingActivity().Run();
                    listingCount++;
                    break;

                case 4:
                    SaveLog();
                    break;
            }
        }
    }

    static void SaveLog()
    {
        string text =
            $"Breathing: {breathingCount}\n" +
            $"Reflection: {reflectionCount}\n" +
            $"Listing: {listingCount}\n";

        File.WriteAllText("log.txt", text);

        Console.WriteLine("\nLog saved to file.");
        Console.ReadKey();
    }
}