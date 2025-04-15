public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000 * 0.62; // miles
    }
    public override double CalculateSpeed()
    {
        return CalculateDistance() / GetTime() * 60; // mph
    }
    public override double CalculatePace()
    {
        return GetTime() / CalculateDistance(); // min per mile
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetTime()} min): Distance {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile.";
    }
}