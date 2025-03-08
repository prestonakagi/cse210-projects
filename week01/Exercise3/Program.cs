using System;

class Program
{
    static void Main(string[] args)
    {        
        Random randomNumber = new Random(); // create instance of Random class.
        int magicNumber = randomNumber.Next(1, 101); // generate random int between 1 and 100.
        int guess = 0;
        // need initiate variables before while loop and maybe for do while loop too.
        
        while (guess != magicNumber)
        {
            /*Console.Write("What is the magic number? ");
            string stringMagicNumber = Console.ReadLine();
            magicNumber = int.Parse(stringMagicNumber);*/

            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}