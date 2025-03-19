using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction defaultFraction = new Fraction();
        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine(defaultFraction.GetDecimalValue());

        Fraction wholeNumFraction = new Fraction(5);
        Console.WriteLine(wholeNumFraction.GetFractionString());
        Console.WriteLine(wholeNumFraction.GetDecimalValue());

        Fraction setBothFraction = new Fraction(3, 4);
        Console.WriteLine(setBothFraction.GetFractionString());
        Console.WriteLine(setBothFraction.GetDecimalValue());
        Console.WriteLine(setBothFraction.GetTop());
        Console.WriteLine(setBothFraction.GetBottom());
        setBothFraction.SetTop(1);
        setBothFraction.SetBottom(3);
        Console.WriteLine(setBothFraction.GetFractionString());
        Console.WriteLine(setBothFraction.GetDecimalValue());        

    }
}