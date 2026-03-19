using System;

public class Entry
{
    public string _Date;
    public string _PromptText;
    public string _EntryText;
    public string _Mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_Date}");
        Console.WriteLine($"Prompt: {_PromptText}");
        Console.WriteLine($"Entry: {_EntryText}");
        Console.WriteLine($"Mood: {_Mood}");
        Console.WriteLine();
    }
}
