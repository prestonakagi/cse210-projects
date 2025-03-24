using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("3 Nephi", 13, 21);
        Scripture scripture = new Scripture(reference, "For where your treasure is, there will your heart be also.");
        scripture.MakeWordList();

        string sixUnder = new string('_', 6);
        Console.WriteLine($"Hello World! This is the ScriptureMemorizer Project. and 6 underscores: {sixUnder}");

        Random random = new Random();
    }
}