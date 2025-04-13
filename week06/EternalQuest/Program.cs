using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager goalManager = new GoalManager();

        // test saving to text file ~ delimited
        // create simple goals
        // goalManager.CreateGoal();
        // goalManager.CreateGoal();
        // goalManager.CreateGoal();
        // goalManager.ListGoalNames();
        // goalManager.ListGoalDetails();
        // goalManager.SaveGoals();

        // test loading then saving to simpletest3.txt. simpletest should appear to append to simpletest2
            // Every time hit VS code's Run button, does not save in Program's memory in the List.
        // test loading simpletest2.txt and save to simpletest.txt.
        goalManager.LoadGoals();
        goalManager.SaveGoals();

    }
}