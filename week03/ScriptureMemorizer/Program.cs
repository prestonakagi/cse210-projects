using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("3 Nephi", 13, 21);
        Scripture scripture = new Scripture(reference, "For where your treasure is, there will your heart be also.");
        scripture.MakeWordList();

        Console.WriteLine(scripture.DisplayText());
        
        Random random = new Random();

        // Console.WriteLine(scripture.IsCompletelyHidden());
        bool isCompletelyHidden = scripture.IsCompletelyHidden();
        string decision = "";


        while (decision != "quit" || isCompletelyHidden == false)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.Write("");
            decision = Console.ReadLine();

            Console.Clear();

            scripture.HideRandomWords(3);

            Console.WriteLine(scripture.DisplayText());

            // Console.WriteLine(scripture.IsCompletelyHidden());
            isCompletelyHidden = scripture.IsCompletelyHidden();
            // isCompletelyHidden = true;
        }
    }
}