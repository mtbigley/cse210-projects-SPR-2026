using System;

class Program
{
    static void Main(string[] args)
    {
        // Get first name
        Console.WriteLine("What is your first name? ");
        string fname = Console.ReadLine();
        // Get last name
        Console.WriteLine("What is your last name? "); 
        string lname = Console.ReadLine();

        // print names in james bond order
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}