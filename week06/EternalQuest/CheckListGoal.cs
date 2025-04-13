public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

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
        // need check IsComplete()
        if (IsComplete() == false)
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
        return ""; // stub
    }
}