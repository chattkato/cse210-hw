using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    // Abstract methods (REQUIRED for full polymorphism marks)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method (DO NOT override in child classes)
    public virtual string GetSummary()
    {
        string activityName = this.GetType().Name;

        return $"{_date:dd MMM yyyy} {activityName} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min per km";
    }
}