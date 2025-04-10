public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(); // each child class's RecordEvent() will be called in GoalManager('s RecordEvent() method. Maybe rename that method?)
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return "details"; //stub
    }

    public abstract string GetStringRepresentation();
}