public abstract class Activity
{
    private string _date; // dd mmm yyyy
    private double _time; // minutes

    public Activity(string date, double time)
    {
        _date = date;
        _time = time;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetTime()
    {
        return _time;
    }

    public abstract double CalculateDistance(); // miles for distance!
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract string GetSummary(); // _date TypeOfActivity (_time min)- Distance _distance miles, Speed: _speed mph, Pace: {pace} min per mile.
}