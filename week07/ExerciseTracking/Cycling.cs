public class Cycling : Activity
{
    private double _speed; // mph

    public Cycling(string date, double time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * GetTime() / 60; // miles
    }
    public override double CalculateSpeed()
    {
        return _speed; // each method that has value as attribute, just return the attribute.
    }
    public override double CalculatePace()
    {
        return GetTime() / CalculateDistance(); //min per mile
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetTime()} min): Distance {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile.";
    }
}