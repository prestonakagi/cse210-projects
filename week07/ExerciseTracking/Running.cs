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
        return 3.3; //stub
    }
    public override double CalculatePace()
    {
        return 3.3; //stub
    }
    public override string GetSummary()
    {
        return "stub";
    }
}