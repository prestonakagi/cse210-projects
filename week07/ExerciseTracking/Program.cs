using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running running = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycling = new Cycling("05 Nov 2022", 40, 10.0);
        Swimming swimming = new Swimming("07 Nov 2022", 40, 80);

        List<Activity> activities = new List<Activity>(){};
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity exercise in activities)
        {
            string toWrite = exercise.GetSummary();
            Console.WriteLine(toWrite);
        }

    }
}