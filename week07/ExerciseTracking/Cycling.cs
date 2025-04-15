public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return 3.3; //stub
    }
    public override double CalculateSpeed()
    {
        return _speed; // each method that has value as attribute, just return the attribute.
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