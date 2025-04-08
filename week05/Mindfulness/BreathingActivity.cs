public class BreathingActivity : Activity
{
    // calling the parent constructor using "base"!
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {}

    public void Run()
    {
        double numberOfTimes = GetDuration() / 8;
        double loopCounter = Math.Ceiling(numberOfTimes) + 1; // with no plus 1, loopCounter is 8 seconds less than _duration seconds.
        
        DisplayStartingMessage();
        ShowSpinner(9);
        
        // start while loop
        while (loopCounter > 0) 
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(3);
            Console.Write("\nNow breathe out...");
            ShowCountDown(5);

            loopCounter -= 1;
        }

        DisplayEndingMessage();
        ShowSpinner(9);
    }
}