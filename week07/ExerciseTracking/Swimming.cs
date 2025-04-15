public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return 3.3; //stub
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