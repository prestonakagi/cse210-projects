using System;

class Program
{
    static void Main(string[] args)
    {
        // static for "regular"/non-Class function.
        // function general structure:
        /* static returnType FunctionName(dtype parameter1, dtype parameter2)
           {
                function_body
           }
        */

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");            
        }
        
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite integer number: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            /* could use Math.Pow() like following:
            int squared = (int)Math.Pow(number, 2);
            the (int)Ma... part "casts the result from a double value to int".
            */
            return squared;
        }

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }

        static void Main()
        {
            DisplayWelcome();

            string name = PromptUserName();
            int number = PromptUserNumber();
            int squared = SquareNumber(number);

            DisplayResult(name, squared);
        }

        Main();
    }
}