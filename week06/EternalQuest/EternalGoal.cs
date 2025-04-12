public class EternalGoal : Goal
{
    // no attributes specifc for EternalGoals
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Congrats on doing one step of the {GetName()} goal! You've earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return ""; // stub
    }
}