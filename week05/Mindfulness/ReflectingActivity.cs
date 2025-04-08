public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    // What is difference between prompts and questions??
    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you did something difficult.");
        _prompts.Add("Think of a time when you improvised.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something even though you were scared.");

        Random random = new Random();
        int randIndex = random.Next(_prompts.Count);
        // " --- prompt? --- "
        
        return $" --- {_prompts[randIndex]} --- ";
    }

    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when the experience was done?");
        _questions.Add("What did you learn about yourself from this experience?");
        _questions.Add("How did this experience improve your life?");

        Random random = new Random();
        int randIndex = random.Next(_questions.Count);
        
        return $"> {_questions[randIndex]} ";
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    public void Run()
    {

        DisplayStartingMessage();
        ShowSpinner(9);

        Console.WriteLine($"\nConsider the following prompt:\n");
        // Display prompt
        DisplayPrompt();
        Console.Write("\nWhen you have something in mind, press enter to continue.\n");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            // Wait for the Enter key to be pressed. This works, so keep empty!
        }
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.WriteLine($"You may begin in: "); // Countdown show in the space
        ShowCountDown(5);
        // clear console
        Console.Clear();
        
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());

        while (currentTime < futureTime)
        {
            DisplayQuestions(); // spinner show in space
            ShowSpinner(25);

            currentTime = DateTime.Now;  // TODO: Why not displaying another question?
        }
        
        DisplayEndingMessage();
        ShowSpinner(9);
    }
}