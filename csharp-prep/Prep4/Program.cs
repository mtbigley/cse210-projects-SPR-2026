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

        // Loop while number entered != 0
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

    }
}