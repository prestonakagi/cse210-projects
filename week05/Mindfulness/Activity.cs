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

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"This activity will help you {_description}.\n");
        Console.Write($"How long, in seconds, would you like for your session?" );
        _duration = int.Parse(Console.ReadLine());
        // clear console
        Console.Clear();
        Console.WriteLine("\nGet ready...");
        // spinner
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\n\nWell done!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        // spinner
        // (go back to menu)
    }

    public void ShowSpinner(int seconds)
    {
        // test 0.5 sec sleeps fo seconds variable > 3.
        double counterStart = 0;
        double counterEnd = Math.Ceiling(seconds / (6 * 0.25)); // greater than 1.5 seconds!

        // number of loops equals rounded up( (seconds / (6 * 0.___ sec in below sleeps)))

        while (counterStart <= counterEnd) {

            // Write then pause for a bit. Thread.Sleep() parameter is int in milliseconds.
            // \b is backspace character like pushing left arrow on keyboard.
                // "\b \b"  writes a blank space over the previous character and then moves left again.
            // Console.Write(">");
            // Thread.Sleep(166);
            // Console.Write("\b \b");
            // Console.Write(" >");
            // Thread.Sleep(166);
            // Console.Write("\b\b  \b\b");
            // Console.Write("  >");
            // Thread.Sleep(166);
            // Console.Write("\b\b\b   \b\b\b");
            // Console.Write("  <");
            // Thread.Sleep(166);
            // Console.Write("\b\b\b   \b\b\b");
            // Console.Write(" <");
            // Thread.Sleep(166);
            // Console.Write("\b\b  \b\b");
            // Console.Write("<");
            // Thread.Sleep(166);
            // Console.Write("\b \b"); // loop thru this
            // Need to advance counterStart by 1

            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("x");
            Thread.Sleep(250);
            Console.Write("\b \b");

            counterStart++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        int countDown = seconds;

        while (countDown != 0) {

        Console.Write(countDown);
        Thread.Sleep(1000);
        countDown -= 1;
        Console.Write("\b \b");        
        }
    }
}