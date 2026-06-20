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
            string username = Console.ReadLine();

            return username; 
        }

        // Define Favorite number prompt function
        int PromptUserNumber()
        {
            // Store user input into string named FavoriteNumber
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine(); 

            // parse FavoriteNumber
            int favoriteNumber = int.Parse(input);

            return favoriteNumber;
        }

        // Define Birth year prompt function
        int PromptUserBirthYear()
        {
            // Store user input into string named BirthYear
            Console.Write("Please enter the year you were born: ");
            string input = Console.ReadLine(); 

            // parse BirthYear
            int birthYear = int.Parse(input); 

            return birthYear;
        }

        // Define SquareNumber function
        int SquareNumber(int number)
        {
            // take parameter number and square it
            int squaredNumber = number * number; 

            return squaredNumber; 
        }

        // Define Display results function
        void DisplayResults(string username, int favoriteNumber, int birthYear)
        {
            /* Crunch the numbers */
            
            // Square the favorite number 
            int faveSquared = SquareNumber(favoriteNumber);

            // fetch current year for age calc
            int currentYear = DateTime.Now.Year; 

            // Calculate current age
            int ageinYears = currentYear - birthYear; 

            // Display results
            Console.WriteLine($"{username}, the square of your favorite number is {faveSquared}");
            Console.WriteLine($"{username}, you will turn {ageinYears} this year.");
        }

        // Call functions and store results into useable variables
        DisplayWelcome();
        string Username = PromptUserName(); 
        int UserNumber = PromptUserNumber();
        int UserBirthYear = PromptUserBirthYear(); 
        DisplayResults(Username, UserNumber, UserBirthYear); 
    }
}