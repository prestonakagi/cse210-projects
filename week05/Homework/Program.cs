using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment testAssign = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine($"{testAssign.GetSummary()}");

        MathAssignment testMath = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");

        Console.WriteLine($"{testMath.GetSummary()}\n{testMath.GetHomeworkList()}");

        WritingAssignment testWriting = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine($"{testWriting.GetSummary()}\n{testWriting.GetWritingInformation()}");
    }
}