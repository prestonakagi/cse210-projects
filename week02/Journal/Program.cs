using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        PromptGenerator prompter = new PromptGenerator();
        // Console.WriteLine($"{prompter._prompts[4]}");

        Entry testentry = new Entry();
        testentry._date = "03/15/25";
        testentry._promptText = prompter.GetRandomPrompt();
        testentry._entryText = "My favorite color is orange, no....AAAUGH!";
        testentry.Display();

        // test Journal class
        // Journal testjournal = new Journal();
        // testjournal.AddEntry(testentry);
        // Console.WriteLine(testjournal._entries);
    }
}