using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone.",
        "Think of a time you did something difficult.",
        "Think of a time you helped someone.",
        "Think of a time you showed strength."
    };

    private List<string> _unusedPrompts;

    public ReflectionActivity()
        : base("Reflection Activity",
        "Reflect on your strengths and experiences.")
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    public void Run()
    {
        Start();
        Random rand = new Random();

        if (_unusedPrompts.Count == 0)
            _unusedPrompts = new List<string>(_prompts);

        int index = rand.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);

        Console.WriteLine("\n" + prompt);
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nReflect...");
            ShowSpinner(4);
        }

        End();
    }
}