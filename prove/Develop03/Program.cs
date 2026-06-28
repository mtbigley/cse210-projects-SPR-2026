using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Luke", 17, 20, 21); // create reference

        // create scripture
        Scripture scripture = new Scripture(reference, "And when he was demanded of the Pharisees when the kingdom of God should come he answered them and said The kingdom of God cometh not with observation Neither shall they say Lo here or lo there for behold the kingdom of God is within you");

        while (!scripture.IsCompletelyHidden()) //Continue program until every word is hidden or until user inputs quit 
        {
            Console.Clear(); 

            Console.WriteLine(scripture.GetDisplayText()); // call scripture display text 

            Console.WriteLine(); 

            Console.Write("Press Enter to continue or type 'quit': "); // prompt user input to continue or quit

            string input = Console.ReadLine(); 

            if (input == "quit")
            {
                break; 
            }

            scripture.HideRandomWords(); // hide random words
        }

        Console.Clear(); 
        Console.WriteLine(scripture.GetDisplayText()); // display blanks 

        Console.WriteLine(); 
        Console.WriteLine("Program Finished."); // inform user program is complete 
    }
}