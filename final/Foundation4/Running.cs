using System;

/// <summary>
/// Represents an instance of a running activity.
/// Initializes a new instance of the Running class with the specified date, minutes, and distance.
/// </summary>

public class Running : Activity
{
    private double _distance;

    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / Minutes) * 60;
    public override double GetPace() => Minutes / _distance;
}