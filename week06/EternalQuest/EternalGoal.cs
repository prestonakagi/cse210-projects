public class EternalGoal : Goal
{
    // no attributes specifc for EternalGoals
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {}

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false; // stub
    }

    public override string GetStringRepresentation()
    {
        return ""; // stub
    }
}