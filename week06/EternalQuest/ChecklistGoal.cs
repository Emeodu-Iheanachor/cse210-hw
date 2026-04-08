using System;

class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, int points, int targetCount, int bonus) : base(name, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override string GetDetailsString()
    {
        string status = _timesCompleted >= _targetCount ? "[X]" : "[ ]";
        return $"{status} {_name} (Completed {_timesCompleted}/{_targetCount})";
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
                return _points + _bonus; // Final bonus
            return _points;
        }
        return 0;
    }
}