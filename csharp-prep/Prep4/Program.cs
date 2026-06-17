using System;

class Program
{
    static void Main(string[] args)
    {
        // Introduce program 
        Console.WriteLine("Hi! I'm a program to help you understand characterstics of a group of numbers.");
        Console.WriteLine("I calculate the sum, average, and largest number of a list of numbers you provide.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // initialize list
        List<double> numbers = new List<double>();

        // initialize input variable 'number'
        double number; 

        // Loop while number entered != 0 to retrieve as many user entered numbers as entered
        do
        {
            // retrieve user number 
            Console.Write("Enter number: ");
            string numberEntered = Console.ReadLine(); 

            // parse user number
            number = double.Parse(numberEntered);

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Crunch the numbers

        // Sum
        double sumOfNumbers = numbers.Sum();
        Console.WriteLine($"The sum is: {sumOfNumbers}");

        // Average
        double avgOfNumbers = numbers.Average();
        Console.WriteLine($"The average is: {avgOfNumbers}");

        // Largest
        double lrgOfNumbers = numbers.Max(); 
        Console.WriteLine($"The largest number is: {lrgOfNumbers}");

        // Smallest
        double smlOfNumbers = numbers.Min(); 
        Console.WriteLine($"The smallest number is: {smlOfNumbers}");

        // // test print list
        // foreach (double value in numbers)
        // {
        //     Console.WriteLine(value);
        // }
    }
}