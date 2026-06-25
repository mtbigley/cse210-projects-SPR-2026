using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction(); 
        Console.WriteLine(defaultFraction.GetFractionString()); 
        Console.WriteLine(defaultFraction.GetDecimalValue()); 

        Fraction topFraction = new Fraction(16); 
        Console.WriteLine(topFraction.GetFractionString()); 
        Console.WriteLine(topFraction.GetDecimalValue()); 

        Fraction fullFraction = new Fraction(16/64); 
        Console.WriteLine(fullFraction.GetFractionString());
        Console.WriteLine(fullFraction.GetDecimalValue()); 
    }
}