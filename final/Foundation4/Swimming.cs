// Swimming class
public class Swimming : Activity
{
    private int _laps;

    public int Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}
