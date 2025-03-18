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

        // make instances of Entry and Journal classes
        Entry testEntry = new Entry();
        Journal currentJournal = new Journal();

        while (userOption != "5")
        {
            // if statements for each userOption
            // have each option have user input to set attribute values.
            // at end of each options code, call ChooseMenuOption().
            // for write option, WriteLine of randomPrompt. Keep just one Entry instance. call ChooseMenuOption().

            if (userOption == "1")
            {
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



            // Test how to add to list in Entry class!!
            // else if (userOption == "4")
            // {
            //     testEntry._promptText = "who you?";
            //     testEntry._date = "5/7/25";
            //     testEntry._entryText = "hiiiiiiiii";
            //     currentJournal.AddEntry(testEntry);
            //     // testEntry.Display(); // Entry Display() method is good.
            //     // Debug Fix attempt 1: For more than one entry at one session (not clicking 5 Quit), 
            //     // do another AddEntry(), then next Option 1 will change last Entry's attributes.
            //         // BUT THIS will not work for just 1 entry!!
            //     currentJournal.DisplayAll(); // displays 1 of correct testEntry as expected.

            //     testEntry._promptText = "who needs this?";
            //     testEntry._date = "11/11/25";
            //     testEntry._entryText = "byeeeeeeeeee";  // Debug: The re-assigning lines changes the 1st Entry's attributes in the List _entries.
            //     currentJournal.AddEntry(testEntry);  // Debug: Adds the 2nd entry to List _entries.
            //     // testEntry.Display(); // Entry Display() method is good.
            //     currentJournal.DisplayAll(); // incorrectly (for first entry) displays 2 of the 2nd entry.

            //     userOption = ChooseMenuOption();   
            // }

            // // test Journal class
            // Journal testJournal = new Journal();
            // testJournal.AddEntry(testEntry);
            // // Console.WriteLine(testJournal._entries[0]._date); //worked!
            // testJournal.DisplayAll();

            // // testJournal.SaveToFile(@"C:\Users\prest\OneDrive\Desktop\testJournal.txt");
            // // use relative path (to "same directory", saved in the bin directory of Journal directory of week02 directory.)
            // testJournal.SaveToFile();

            // Entry testEntry3 = new Entry();
            // testEntry3._date = "07/07/25";
            // testEntry3._promptText = prompter.GetRandomPrompt();
            // testEntry3._entryText = "My favorite color is green, no....AAAUGH!";
            // // testEntry3.Display();

            // Entry testEntry4 = new Entry();
            // testEntry4._date = "08/28/25";
            // testEntry4._promptText = prompter.GetRandomPrompt();
            // testEntry4._entryText = "My favorite food";
            // // testEntry4.Display();

            // testJournal.AddEntry(testEntry3);
            // testJournal.AddEntry(testEntry4);
            // testJournal.DisplayAll(); // 4 entries in current journal in Program.

            // Console.WriteLine("Before LoadFromFile()");
            // testJournal.LoadFromFile(); // Clear _entries list and save the first 2 entries that are in file.
            // Console.WriteLine("After LoadFromFile()");

            // testJournal.DisplayAll(); // display in terminal (entries in file) current journal (if delete the text file first, the first 2 entries). Did it work? YES!
        }
        
    }
}