using System;

class Program
{
    static void Main(string[] args)
    {
                    // menu function
        static string ChooseMenuOption()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Please type the option number from the menu. ");
            string option = Console.ReadLine();
            return option;
        }

        string userOption = ChooseMenuOption();

        while (userOption != "4")
        {

            // List<string> testStrings = new List<string>();
            // testStrings.Add("Hi");
            // ListingActivity testEnterHit = new ListingActivity("Listing Activity", "description", 5, 3, testStrings);
            // testEnterHit.Run();

            // Activity testSpinner = new Activity("testspinner", "back and forth arrow", 10);
            // testSpinner.ShowSpinner(9);
            // testSpinner.ShowCountDown(5);
            if (userOption == "1")
            {
                Console.Clear();
                BreathingActivity testBreathing = new BreathingActivity("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", 30);
                testBreathing.Run();

                Console.Clear();
                userOption = ChooseMenuOption();
            }

            else if (userOption == "2")
            {
                Console.Clear();
                ReflectingActivity testReflecting = new ReflectingActivity("Reflecting Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", 30);
                testReflecting.Run();

                Console.Clear();
                userOption = ChooseMenuOption();
            }

            else if (userOption == "3")
            {
                Console.Clear();
                ListingActivity testListing = new ListingActivity("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain topic", 30);
                testListing.Run();

                Console.Clear();
                userOption = ChooseMenuOption();
            }
        }
    }
}