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

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
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
        // store info in a string variable (not an attribute, but a variable)
        // Look to contructor for info need to save:
        // Class's name~goal's name~goal's description~goal's points
        // $"ClassName~{GetName()}~{GetDescription()}~{GetPoints()}"
        // check IsComplete()
        bool check = IsComplete(); 
        if (check == false)
        {
            string toWrite = $"SimpleGoal~[ ]~{GetName()}~{GetDescription()}~{GetPoints()}";
            return toWrite;
        }
        else
        {
            string toWrite = $"SimpleGoal~[X]~{GetName()}~{GetDescription()}~{GetPoints()}";
            return toWrite; 
        }
    }
}