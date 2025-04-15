public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus = 40;

    public CheckListGoal(string name, string description, string points, int target) : base(name, description, points)
    {
        _target = target;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    //     public void LoadCompleted(int completed)
    // {
    //     _amountCompleted = completed;
    // }

        public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        // need check IsComplete()
        bool check = IsComplete(); 
        if (check == false)
        {
            Console.WriteLine($"Congrats on doing one instance of the {GetName()} goal! You've earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine($"Congrats on completing the {GetName()} goal! You've earned {GetPoints()} points and {GetBonus()} bonus points!");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"The goal {GetName()} is {GetDescription()}. Completed {_amountCompleted}/{_target} times.";
    }

    public override string GetStringRepresentation()
    {
        // store info in a string variable (not an attribute, but a variable)
        // Look to contructor for info need to save:
        // Class's name~goal's name~goal's description~goal's points
        // $"ClassName~{GetName()}~{GetDescription()}~{GetPoints()}"
        // check IsComplete()
        if (IsComplete() == false)
        {
            string toWrite = $"CheckListGoal~[ ]~{GetName()}~{GetDescription()}~{GetPoints()}~{GetAmountCompleted()}~{GetTarget()}~{GetBonus()}";
            return toWrite;
        }
        else
        {
            string toWrite = $"CheckListGoal~[X]~{GetName()}~{GetDescription()}~{GetPoints()}~{GetAmountCompleted()}~{GetTarget()}~{GetBonus()}";
            return toWrite; 
        }
    }
}