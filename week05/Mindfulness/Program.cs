using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        List<string> testStrings = new List<string>();
        testStrings.Add("Hi");
        ListingActivity testEnterHit = new ListingActivity("Listing Activity", "description", 5, 3, testStrings);
        testEnterHit.Run();
    }
}