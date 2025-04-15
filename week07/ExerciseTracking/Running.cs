public class Running : Activity
{
    private double _distance;

    public Running(string date, double time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance; // each method that has value as attribute, just return the attribute.
    }
    public override double CalculateSpeed()
    {
        return _distance / GetTime() * 60; // mph
    }
    public override double CalculatePace()
    {
        return GetTime() / _distance; // min per mile
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetTime()} min): Distance {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile.";
    }
}