using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
              "This activity helps you list positive things in your life.")
    {
    }

    public void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);

        Console.Write("\nStart in: ");
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        End();
    }
}