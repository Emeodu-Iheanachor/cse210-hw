using System;

abstract class Goal
{
    protected string _name;
    protected int _points;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    // Display goal progress/details
    public abstract string GetDetailsString();

    // Record event for the goal; returns points earned
    public abstract int RecordEvent();
}