using System;

class Program
{
    static void Main(string[] args)
    {
        // Start by introducing the program and generating the 'magic' number
        Console.WriteLine("Hi! I'm a magic number guesser program.");
        Console.WriteLine("I've got a magic number from 1 - 100. Try and guess it! I'll tell you if you're high or low.");

        //Random number generator
        Random randomGenerator = new Random(); 
        int magicNum = randomGenerator.Next(1,100); 
        
        // Have user input guesses for the magic number
        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine(); 

        // parse user guess 
        double guessNum = double.Parse(guess);
        
        do
        {
            // if statement to determine if user needs to go higher or lower
            if (guessNum > magicNum)
            {
                Console.WriteLine("Try guessing lower!");
            }

            else if (guessNum < magicNum)
            {
                Console.WriteLine("Try guessing higher!");
            }

            if (guessNum != magicNum)
            {
                Console.WriteLine("What is your guess?"); 
                guess = Console.ReadLine();
                guessNum = double.Parse(guess); 
            }

        } while (guessNum != magicNum); 

        Console.WriteLine("You got it!");


        /* ____Old code leftover from earlier build where user supplied the magic number____
        // string magic = Console.ReadLine();
        
        // // Parse magic number 
        // double magicNum = double.Parse(magic);
        */

    }
}