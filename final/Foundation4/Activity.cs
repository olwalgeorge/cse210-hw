// Base Activity class
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int Minutes
    {
        get { return _minutes; }
        set { _minutes = value; }
    }

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes; 
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}

