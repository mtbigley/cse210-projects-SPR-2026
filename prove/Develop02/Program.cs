using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt prompt = new Prompt();

        while (true)
        {      
            Console.WriteLine(); 
            Console.WriteLine("Welcome to the Journal, please select from the menu.");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            if (input == "1")
                {
                    string prompt1 = prompt.GetPrompt();
                    Console.WriteLine(prompt1); 
                    Console.Write("> ");

                    string userEntry = Console.ReadLine(); 

                    Entry entry = new Entry();
                    
                    DateTime theCurrentTime = DateTime.Now;
                    entry._date = theCurrentTime.ToShortDateString();
                    entry._prompt = prompt1;
                    entry._entry = userEntry;

                    journal.AddEntry(entry);
                }
            
            else if (input == "2")
            {
                journal.DisplayAll();
            }

            else if (input == "3")
            {
                Console.Write("Enter file name:");
                string fileName = Console.ReadLine(); 
                journal.LoadFromFile(fileName);
            }

            else if (input == "4")
            {
                Console.Write("Enter file name:");
                string fileName = Console.ReadLine(); 
                journal.SaveToFile(fileName);
            }

            else if (input == "5")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid entry-- please try again.");
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }
    }
}