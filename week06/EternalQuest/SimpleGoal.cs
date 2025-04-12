public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {}

    public override void RecordEvent()
    {
        // call this method when simple goal is done.
        _isComplete = true;
        Console.WriteLine($"Congrats on completing the {GetName()} goal! You've earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return ""; // stub
    }
}