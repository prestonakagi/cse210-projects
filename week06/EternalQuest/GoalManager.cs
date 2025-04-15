public class GoalManager
{
    // Start() is for menu options at end of each loop.
    // Rename this class's RecordEvent() to ManageRecordEvent()

    private List<Goal> _goals = new List<Goal>(){};
    private int _score = 0; // total points = score
    private string _checkBox = "[ ]";


    public void SetScore(int score)
    {
        _score = score;
    }

    public void Start()
    {
        // menu function
        string option = Menu(); // need this to not have infinite loops
        
        while (option != "8")
        {
            if (option == "1")
            {
                DisplayPlayerInfo();
                // Start(); // doesn't work. Keeps repeating loop when 8 is entered.
                Console.WriteLine("");
                option = Menu(); // need this to not have infinite loops
            }
            else if (option == "2")
            {
                ListGoalNames();
                // Start(); // doesn't work. Keeps repeating loop when 8 is entered.
                Console.WriteLine("");
                option = Menu();
            }
            else if (option == "3")
            {
                ListGoalDetails();
                // Start(); // doesn't work. Keeps repeating loop when 8 is entered.
                Console.WriteLine("");
                option = Menu();
            }
            else if (option == "4")
            {
                CreateGoal();
                // Start(); // doesn't work. Keeps repeating loop when 8 is entered.
                Console.WriteLine("");
                option = Menu();
            }
            else if (option == "5")
            {
                ManageRecordEvent();
                // Start(); // doesn't work. Keeps repeating loop when 8 is entered.
                Console.WriteLine("");
                option = Menu();
            }
            else if (option == "6")
            {
                SaveGoals();
                // Start(); // doesn't work. Keeps repeating loop when 8 is entered.
                Console.WriteLine("");
                option = Menu();
            }
            else if (option == "7")
            {
                LoadGoals();
                // Start(); // doesn't work. Keeps repeating loop when 8 is entered.
                Console.WriteLine("");
                option = Menu();
            }
        }
    }

    public string Menu()
    {
        // menu display and option selection
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("(if adding to an existing file, first load, then write, then save):");
        Console.WriteLine("1. Current Score");
        Console.WriteLine("2. Display Goal Names");
        Console.WriteLine("3. Display Goal Details");
        Console.WriteLine("4. Create a Goal");
        Console.WriteLine("5. Record a Goal Event");
        Console.WriteLine("6. Save Current Goals");
        Console.WriteLine("7. Load Goals From File");
        Console.WriteLine("8. Quit");
        Console.Write("Please type the option number from the menu. ");
        string choice = Console.ReadLine();
        return choice;  
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
        // show if checkbox is complete and, for checklistgoal, progress like 2/3. Write these before description.

        Console.WriteLine("The details of each of your goals:");
        foreach (Goal goal in _goals)
        {
            // if goal is SimpleGoal or goal is EternalGoal
            if (goal.IsComplete() == false)
            {
                Console.WriteLine($"{_checkBox} {goal.GetDetailsString()}");
            }
            else
            {
                _checkBox = "[X]";
                Console.WriteLine($"{_checkBox} {goal.GetDetailsString()}");
            }
            // if goal is CheckListGoal
            // Console.WriteLine($"{_checkBox} {goal.GetAmountCompleted()}/{goal.GetTarget()} {goal.GetDescription()}");

        }
    }

    public void CreateGoal()
    {
        Console.Write("What is a description of your goal? ");
        string userDescription = Console.ReadLine();
        Console.Write(@"Based on the description, what type is your goal: SimpleGoal, EternalGoal, or CheckListGoal?
        SimpleGoal = 1 time and done. Example: do 5 pushups today at noon.
        EternalGoal = never ends or fully completed. Example: read scriptures every day.
        CheckListGoal = completed after n amount of times. Example: exercise 3 times this week.
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
            Console.WriteLine("You have finished creating your goal!");
        }
        else if (type.ToLower() == "eternalgoal" || type.ToLower() == "eternal goal")
        {
            Console.Write("When you do 1 instance of this goal, how many points will you be awarded? ");
            string userPoints = Console.ReadLine();

            EternalGoal eGoal = new EternalGoal(userName, userDescription, userPoints);
            _goals.Add(eGoal);
            Console.WriteLine("You have finished creating your goal!");         
            
        }
        else if (type.ToLower() == "checklistgoal" || type.ToLower() == "check list goal" || type.ToLower() =="checklist goal")
        {
            Console.Write("Please enter the total number of times you will do something for this goal. ");
            string userTargetString = Console.ReadLine(); // convert to int
            int userTarget = int.Parse(userTargetString);
            Console.Write("When you do 1 instance of this goal, how many points will you be awarded? ");
            string userPoints = Console.ReadLine();

            CheckListGoal cGoal = new CheckListGoal(userName, userDescription, userPoints, userTarget);
            _goals.Add(cGoal);
            Console.WriteLine("You have finished creating your goal!");         
        }        
    }

    public void ManageRecordEvent()
    {
        // records event thru the Goal.RecordEvent(), and will add points to (total) score.
        Console.Write("What is the name of the goal you have completed or worked toward? ");
        string goalToRecord = Console.ReadLine();
        foreach (Goal goal in _goals)
        {
            if (goalToRecord.ToLower() == goal.GetName().ToLower())
            {
                if (goal is SimpleGoal || goal is EternalGoal)
                {
                    goal.RecordEvent();
                    string pointsString = goal.GetPoints();
                    int pointsInt = int.Parse(pointsString);
                    _score += pointsInt;
                }
                else if (goal is CheckListGoal)
                {
                    if (goal.IsComplete() == false)
                    {
                        goal.RecordEvent();
                        string pointsString = goal.GetPoints();
                        int pointsInt = int.Parse(pointsString);
                        _score += pointsInt; 
                    }
                    else
                    {
                        goal.RecordEvent();
                        string pointsString = goal.GetPoints();
                        int pointsInt = int.Parse(pointsString);
                        _score += pointsInt;
                        _score += goal.RetrieveBonus(); // had error of checking the Goal class for the .GetBonus() method.
                    }
                }
            }
        }
    }

    public void SaveGoals()
    {
        // Prompt user for a filename, then save complete current journal "to that file location"; 
            // is user input for just a name or for the path?? I'm going with (relative) path for now. SAVES IN bin folder!!
        // The below file is a string of the path (doesn't need start with @ before opening ") of where to save the file 
            // with filename at end and .filetype.
        // For core requirements, delimiter is ~ instead of a comma.

        Console.Write("Enter a text filename to save; example: 'filename.txt': ");
        string file = Console.ReadLine();

        using(System.IO.StreamWriter objFile = new System.IO.StreamWriter(file, true)) // true appends, false overwrites.
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                objFile.WriteLine(_goals[i].GetStringRepresentation()); // uses ~ as delimiter.
            }
            
            // Save current score at end of file.
            objFile.WriteLine($"Score~{_score}");
        }
    }

    public void LoadGoals()
    {
        // When load goals from text file (~ delimited), need to blank _goals List, then CreateGoal() steps for each file line 
        // with delimited chunks saved to the variables to detect which type of goal, goal name, description, and point values (instead of user input).
            // SEE EACH TYPE OF GOAL CLASS'S GetStringRepresentation()!!
            // will split lines on ~ delimiter.

        // parts index variables
        int indexType = 0;
        int indexCheckBox = 1;
        int indexName = 2;
        int indexDescription = 3;
        int indexPoints = 4;
        int indexAmountCompleted = 5;
        int indexTarget = 6;
        // int indexBonus = 7;

        _goals.Clear();

        // read text file, split on ~ delimiter
        Console.Write("Enter a text filename to load; example: 'filename.txt': ");
        string file = Console.ReadLine();

        using (StreamReader sr = new StreamReader(file))
        {
            // while not at end of "Stream"
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split("~");  //not sure what the [] means
                List<string> lists = new List<string>(values);
                
                // check type first!
                string goalType = lists[indexType];
                string type = goalType;
                if (type.ToLower() == "simplegoal" || type.ToLower() == "simple goal")
                {
                    // SimpleGoal variables for lists's index numbers.
                    string goalName = lists[indexName];
                    string goalDescription = lists[indexDescription];
                    string goalPoints = lists[indexPoints];

                    SimpleGoal sGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                    if (lists[indexCheckBox] == "[X]")
                    {
                        sGoal.SetIsComplete(true);
                    }
                    else if (lists[indexCheckBox] == "[ ]")
                    {
                        sGoal.SetIsComplete(false);
                    }
                    _goals.Add(sGoal);
                }
                else if (type.ToLower() == "eternalgoal" || type.ToLower() == "eternal goal")
                {
                    // EternalGoal variables for lists's index numbers.
                    string goalName = lists[indexName];
                    string goalDescription = lists[indexDescription];
                    string goalPoints = lists[indexPoints];

                    EternalGoal eGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(eGoal);
                }
                else if (type.ToLower() == "checklistgoal" || type.ToLower() == "check list goal" || type.ToLower() =="checklist goal")
                {
                    // CheckListGoal variables for lists's index numbers.
                    string goalName = lists[indexName];
                    string goalDescription = lists[indexDescription];
                    string goalPoints = lists[indexPoints];
                    int goalTarget = int.Parse(lists[indexTarget]);

                    CheckListGoal cGoal = new CheckListGoal(goalName, goalDescription, goalPoints, goalTarget);
                    cGoal.SetAmountCompleted(int.Parse(lists[indexAmountCompleted]));
                    _goals.Add(cGoal);         
                }
                else if (type.ToLower() == "score")
                {
                    int loadedScore = int.Parse(lists[1]);
                    SetScore(loadedScore);
                }
            }
        }
    }
}