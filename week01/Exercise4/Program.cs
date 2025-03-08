using System;

class Program
{
    static void Main(string[] args)
    {
        /* lesson said put "using System.Collections.Generic" at top of script
        whenever use List or other standard collection. 
        HOWEVER, the sample solution does not have that, so assume the environment
        is set up to already have that. */

        List<float> numbers = new List<float>();

        float userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = float.Parse(userInput);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        float total = 0;
        foreach (float number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");

        int countOfNumbers = numbers.Count;
        float average = total / countOfNumbers;
        Console.WriteLine($"The average is: {average}");

        // find maxiumum number
        float largest = -1000000000000000000;
        for (int i = 1; i < countOfNumbers; i++)
        {
            if (numbers[i] >= largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine($"The largest number is: {largest}");
    }
}