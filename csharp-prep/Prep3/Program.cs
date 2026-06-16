using System;

class Program
{
    static void Main(string[] args)
    {
        // Start by introducing the program and asking the user for a random number
        Console.WriteLine("Hi! I'm a magic number guesser program.");
        Console.WriteLine("Let's start by having you enter a random number below:");
        string magic = Console.ReadLine();
        
        // Parse magic number 
        double magicNum = double.Parse(magic);

        // Have user input guesses for the magic number
        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine(); 

        // parse user guess 
        double guessNum = double.Parse(guess);

        // if statement to determine if user needs to go higher or lower
        if (guessNum > magicNum)
        {
            Console.WriteLine("Try guessing lower!");
        }

        else if (guessNum < magicNum)
        {
            Console.WriteLine("Try guessing higher!");
        }

        else
        {
            Console.WriteLine("You got it!");
        }
    }
}