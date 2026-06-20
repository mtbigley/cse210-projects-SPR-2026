using System;

class Program
{
    static void Main(string[] args)
    {
        // Define welcome function
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // Define Username Prompt function
        string PromptUserName()
        {
            // Store user input into string named Username
            Console.Write("Please enter your name: ");
            string Username = Console.ReadLine();

            return Username; 
        }

        // Define Favorite number prompt function
        int PromptUserNumber()
        {
            // Store user input into string named FavoriteNumber
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine(); 

            // parse FavoriteNumber
            int FavoriteNumber = int.Parse(input);

            return FavoriteNumber;
        }

        // Define Birth year prompt function
        int PromptUserBirthYear()
        {
            // Store user input into string named BirthYear
            Console.Write("Please enter the year you were born: ");
            string input = Console.ReadLine(); 

            // parse BirthYear
            int BirthYear = int.Parse(input); 

            return BirthYear;

        }


        // Call functions 
        DisplayWelcome();
        PromptUserName(); 
        PromptUserNumber();
        PromptUserBirthYear(); 
    }
}