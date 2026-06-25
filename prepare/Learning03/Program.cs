using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction(); // default test case
        Console.WriteLine(defaultFraction.GetFractionString()); 
        Console.WriteLine(defaultFraction.GetDecimalValue()); 

        Fraction topFraction = new Fraction(16); // constructor with numerator test case
        Console.WriteLine(topFraction.GetFractionString()); 
        Console.WriteLine(topFraction.GetDecimalValue()); 

        Fraction fullFraction = new Fraction(16/64); // constructor with numerator and denominator test case 
        Console.WriteLine(fullFraction.GetFractionString());
        Console.WriteLine(fullFraction.GetDecimalValue()); 

        Random random = new Random(); // randomized fraction test-- I've got some tweaks to make here regarding the number before it's good to go
        Fraction randomFraction = new Fraction(); 
        for (int i = 0; i <20; i++)
        {
            int topValue = random.Next(1,11); 
            int bottomValue = random.Next(1,11); 
            randomFraction.SetFractionTop(topValue); 
            randomFraction.SetFractionBottom(bottomValue); 
            Console.Write($"Fraction {i + 1}: "); 
            Console.Write($"string: {randomFraction.GetFractionString()}"); 
            Console.WriteLine($" Number: {randomFraction.GetDecimalValue()}"); 
        }
    }
}