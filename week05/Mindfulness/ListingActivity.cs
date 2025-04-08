public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

   // calling the parent constructor using "base"!
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What good things have happened this week?");
        _prompts.Add("What are your favorite foods?");
        _prompts.Add("What are your favorite movies you have seen?");
        _prompts.Add("What superpowers would you like to have?");

        Random random = new Random();
        int randIndex = random.Next(_prompts.Count);
        // " --- prompt? --- "
        Console.WriteLine($" --- {_prompts[randIndex]} --- ");
    }

    // public List<string> SaveListFromUser()
    // {
    //     return new List<string>(); // stub
    // }

    public void Run()
    {
        List<string> userResponses = new List<string>();

        DisplayStartingMessage();
        ShowSpinner(9);

        Console.WriteLine("List as many responses you can to the following prompt:");
        // Display prompt
        GetRandomPrompt();
        Console.Write("You may begin in: "); //countdown
        ShowCountDown(5);
        // user types answers. When hit enter, ends that one answer and next answer starts on next line.
        Console.Write("\n");
        
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());    

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            userResponses.Add(response);

            currentTime = DateTime.Now;
        }

        // Once timer is done:
        Console.WriteLine($"You listed {userResponses.Count} items!");
        
        DisplayEndingMessage();
        ShowSpinner(9);

    }
}