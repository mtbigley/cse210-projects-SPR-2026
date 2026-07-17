using System;

class Program
{
    static void Main(string[] args)
    {
        // Base assignment
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");

        Console.WriteLine(assignment.GetSummary());

        // Math assignment
        MathAssignment assignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine(assignment1.GetHomeworkList());

        // Writing assignment

        
    }
}