public class GoalManager
{
    // Start() is for menu options at end of each loop.
    // Rename this class's RecordEvent() to ManageRecordEvent()

    private List<Goal> _goals;
    private int _score; // total points = score

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {
        // need to sum all points, so make attribute with List<int>. Add points from goals' methods to list, need to convert the string to int 1st.
        Console.WriteLine($"Your current score is {_score}.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your goals' names:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        // show if checkbox is complete too.

        Console.WriteLine("The details of each of your goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDescription());
        }
    }

    public void CreateGoal()
    {
        Console.Write("What is a description of your goal? ");
        string userDescription = Console.ReadLine();
        Console.Write(@"Based on the description, what type is your goal: SimpleGoal, EternalGoal, or CheckListGoal?
        SimpleGoal = 1 time and done. Example: do 5 pushups today at noon.
        EternalGoal = never ends or fully completed. Example: read scriptures every day.
        CheckListGoal = completed after n amount of times. Esample: exercise 3 times this week.
        ");
        string type = Console.ReadLine();
        Console.Write("What is a short name for your goal? ");
        string userName = Console.ReadLine();

        if (type.ToLower() == "simplegoal" || type.ToLower() == "simple goal")
        {
            Console.Write("When this goal is completed, how many points will you be awarded? ");
            string userPoints = Console.ReadLine();

            SimpleGoal sGoal = new SimpleGoal(userName, userDescription, userPoints);
            _goals.Add(sGoal);
        }
        else if (type.ToLower() == "eternalgoal" || type.ToLower() == "eternal goal")
        {
            Console.Write("When you do 1 instance of this goal, how many points will you be awarded? ");
            string userPoints = Console.ReadLine();

            EternalGoal eGoal = new EternalGoal(userName, userDescription, userPoints);
            _goals.Add(eGoal);            
        }
        else if (type.ToLower() == "checklistgoal" || type.ToLower() == "check list goal" || type.ToLower() =="checklist goal")
        {
            Console.Write("Please enter the total number of times you will do something for this goal. ");
            string userTargetString = Console.ReadLine(); // convert to int
            int userTarget = int.Parse(userTargetString);
            Console.Write("When you do 1 instance of this goal, how many points will you be awarded? ");
            string userPoints = Console.ReadLine();
            Console.Write("When you fully complete this goal, how many bonus points will you be awarded? ");
            string userBonusString = Console.ReadLine(); // convert to int
            int userBonus = int.Parse(userBonusString);

            CheckListGoal cGoal = new CheckListGoal(userName, userDescription, userPoints, userTarget, userBonus);
            _goals.Add(cGoal);            
        }        
    }

    public void ManageRecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}