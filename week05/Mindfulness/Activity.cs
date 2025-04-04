public class Activity
{
    private string _name; // "___ Activity"
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"This activity will help you {_description}.\n");
        Console.Write($"How long, in seconds, would you like for your session?" );
        _duration = int.Parse(Console.ReadLine());
        // clear console
        Console.WriteLine("\nGet ready...");
        // spinner
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!");
        // spinner
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        // spinner
        // (go back to menu)
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }
}