public class ChecklistGoal : Goal
{
    private int _current;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int current, int target, int bonus)
        : base(name, desc, points)
    {
        _current = current;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _current++;
        int earned = GetPoints();

        if (_current == _target)
        {
            earned += _bonus;
        }

        return earned;
    }

    public override bool IsComplete() => _current >= _target;

    public override string GetStatus()
    {
        return $"[{(IsComplete() ? "X" : " ")}] Completed {_current}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"Checklist|{GetName()}|{GetDescription()}|{GetPoints()}|{_current}|{_target}|{_bonus}";
    }
}