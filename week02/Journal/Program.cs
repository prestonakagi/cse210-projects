using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome and menu.
        Console.WriteLine("Welcome to the Journal Program!");
        
        // menu function
        static string ChooseMenuOption()
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("(if adding to an existing file, first load, then write, then save):");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? Please type the number of the option. ");
            string option = Console.ReadLine();
            return option;
        }

        string userOption = ChooseMenuOption();

        // make instance of Journal class
        Journal currentJournal = new Journal();

        while (userOption != "5")
        {
            // if statements for each userOption
            // have each option have user input to set attribute values.
            // at end of each options code, call ChooseMenuOption().
            // for write option, WriteLine of randomPrompt. Make an Entry instance each loop. call ChooseMenuOption().

            // Write one entry
            if (userOption == "1")
            {
                Entry testEntry = new Entry();
                PromptGenerator prompter = new PromptGenerator(); // get a different prompt every time option 1 chosen.
                testEntry._promptText = prompter.GetRandomPrompt();
                Console.WriteLine(testEntry._promptText);
                // need get date automatically from computer
                DateTime currentDate = DateTime.Today;
                testEntry._date = currentDate.ToShortDateString();              
                Console.Write("");
                testEntry._entryText = Console.ReadLine();
                // testEntry.Display();

                currentJournal.AddEntry(testEntry);

                userOption = ChooseMenuOption();
            }

            // Display option is for DisplayAll().
            else if (userOption == "2")
            {
                currentJournal.DisplayAll();
                userOption = ChooseMenuOption(); 
            }

            // Save all entries of currentJournal to a text file, delimited by ~
            else if (userOption == "3")
            {
                currentJournal.SaveToFile();
                userOption = ChooseMenuOption();
            }

            else if (userOption == "4")
            {
                currentJournal.LoadFromFile();
                userOption = ChooseMenuOption();
            }
        }
        
    }
}