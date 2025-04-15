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

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

     public string GetPoints()
    {
        return _points;
    }

    public int RetrieveBonus()
    {
        CheckListGoal rewardBonus = new CheckListGoal("testToGetBonus", "try get bonus to add when ManageRecordEvent", "5", 3);
        return rewardBonus.GetBonus();
    }

    public abstract void RecordEvent(); // each child class's RecordEvent() will be called in GoalManager('s RecordEvent() method. Maybe rename that method?)
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"The goal {_shortName} is {_description}.";
    }

    public abstract string GetStringRepresentation();
}