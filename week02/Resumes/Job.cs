public class Job
{
    // Class attributes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Class methods
    public void DisplayJobDetails()
    {
        // display Job Title (Company) StartYear - EndYear
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}