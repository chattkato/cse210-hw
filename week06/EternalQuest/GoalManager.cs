using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _streak = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public void RecordGoal(int index)
    {
        int points = _goals[index].RecordEvent();

        if (points > 0)
        {
            _streak++;
        }
        else
        {
            _streak = 0;
        }

        int bonus = (_streak >= 3) ? 50 : 0;

        _score += points + bonus;

        Console.WriteLine($"You earned {points} points!");
        if (bonus > 0)
        {
            Console.WriteLine("Streak bonus: +50 points!");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nScore: {_score}");
        Console.WriteLine($"Level: {_score / 500}");
        Console.WriteLine($"Title: {GetTitle()}");
    }

    private string GetTitle()
    {
        if (_score < 500) return "Beginner";
        if (_score < 1500) return "Disciple";
        if (_score < 3000) return "Warrior";
        return "Master";
    }

    public void Save(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetSaveString());
            }
        }
    }

    public void Load(string file)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split("|");

            if (p[0] == "Simple")
                _goals.Add(new SimpleGoal(p[1], p[2], int.Parse(p[3]), bool.Parse(p[4])));

            else if (p[0] == "Eternal")
                _goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3])));

            else if (p[0] == "Checklist")
                _goals.Add(new ChecklistGoal(p[1], p[2], int.Parse(p[3]), int.Parse(p[4]), int.Parse(p[5]), int.Parse(p[6])));
        }
    }
}