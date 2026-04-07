using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who have you helped?",
        "Who inspires you?"
    };

    private List<string> _unusedPrompts;

    public ListingActivity()
        : base("Listing Activity",
        "List as many positive things as you can.")
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    public int Run()
    {
        Start();

        Random rand = new Random();

        if (_unusedPrompts.Count == 0)
            _unusedPrompts = new List<string>(_prompts);

        int index = rand.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);

        Console.WriteLine("\n" + prompt);

        Console.Write("\nStart in: ");
        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        End();

        return count;
    }
}