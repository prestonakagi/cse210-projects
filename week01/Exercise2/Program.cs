using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string stringGrade = Console.ReadLine();
        float grade = float.Parse(stringGrade);
        string letter = "Z";
        
        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine($"Your grade is a {letter}");
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
            Console.WriteLine($"Your grade is a {letter}");
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
            Console.WriteLine($"Your grade is a {letter}");
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
            Console.WriteLine($"Your grade is a {letter}");
        }
        else if (grade < 60)
        {
            letter = "F";
            Console.WriteLine($"Your grade is a {letter}");
        }

        if (grade >= 70)
        {
            Console.WriteLine("You passed the class! Congratulations!");
        }
        else if (grade < 70)
        {
            Console.WriteLine("You did not pass the class. But you will do better next time.");
        }
    }
}