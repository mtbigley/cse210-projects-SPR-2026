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




        // Call functions 
        DisplayWelcome();
        PromptUserName(); 
    }
}