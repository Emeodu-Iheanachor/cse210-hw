using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    // ABSTRACT METHODS (must be overridden)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // SHARED METHOD
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min)- Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}