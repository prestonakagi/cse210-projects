public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false; // stub
    }

    public override string GetDetailsString()
    {
        return ""; // stub
    }

    public override string GetStringRepresentation()
    {
        return ""; // stub
    }
}