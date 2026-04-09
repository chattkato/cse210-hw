using System;

public class ChecklistGoal : Goal
{
    private int _currentCount;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int currentCount, int targetCount, int bonus)
        : base(name, description, points)
    {
        _currentCount = currentCount;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        int pointsEarned = GetPoints();

        if (_currentCount == _targetCount)
        {
            pointsEarned += _bonus;
        }

        return pointsEarned;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete() ? "X" : " ")}] Completed {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"Checklist|{GetName()}|{GetDescription()}|{GetPoints()}|{_currentCount}|{_targetCount}|{_bonus}";
    }
}