using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override string GetDetailsString()
    {
        return $"[∞] {_name}";
    }

    public override int RecordEvent()
    {
        return _points; // Can be recorded infinite times
    }
}