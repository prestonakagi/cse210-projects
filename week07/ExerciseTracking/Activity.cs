public abstract class Activity
{
    private string _date;
    private double _time;

    public Activity(string date, double time)
    {
        _date = date;
        _time = time;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract string GetSummary();
}