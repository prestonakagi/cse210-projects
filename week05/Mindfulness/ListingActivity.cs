public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

   // calling the parent constructor using "base"!
    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {
        return new List<string>(); // stub
    }

    public void Run()
    {
        Console.WriteLine($"\nConsider the following prompt:\n");
        // Display prompt
        Console.Write("When you have something in mind, press enter to continue.\n");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            // Wait for the Enter key to be pressed. This works, so keep empty!
        }
        Console.WriteLine("Enter was clicked.");
    }
}