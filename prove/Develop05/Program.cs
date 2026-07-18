using System;

class Program
{
    static void Main(string[] args)
    {
        ScoreKeeper scoreKeeper = new ScoreKeeper(); 

        while (true)
        {
            Console.Clear(); 

            Console.WriteLine();
            Console.WriteLine("Welcome to the Eternal Quest Program. What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("Please choose from the menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Display score");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Record Event");
            Console.WriteLine("7. Quit");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                PromptCreateGoal(scoreKeeper);

                Console.WriteLine("Goal Created. Press Enter to continue.");
                Console.ReadLine(); 
            }

            else if (input == 2)
            {
                scoreKeeper.ListGoals(); 

                Console.WriteLine(); 
                Console.WriteLine("Press Enter to return to the main menu.");
                Console.ReadLine();
            }

            else if (input == 3)
            {
                scoreKeeper.DisplayScore(); 

                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the main menu.");
                Console.ReadLine();
            }

            else if (input == 4)
            {
                
            }

            else if (input == 5)
            {
                
            }

            else if (input == 6)
            {
                PromptRecordEvent(scoreKeeper);

                Console.WriteLine(); 
                Console.WriteLine("Press Enter to return to the main menu.");
                Console.ReadLine();
            }

            else if (input == 7)
            {
                return;
            }

            else
            {
                Console.WriteLine("Invalid entry-- please try again.");
                Console.WriteLine();
            }
        }

        static void PromptCreateGoal(ScoreKeeper scoreKeeper)
        {
            Console.WriteLine("What type of goal would you like to set for yourself?");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            int goalType = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.WriteLine("Please describe what you'd like to achieve: ");
            string description = Console.ReadLine();

            Console.WriteLine("How many points is this goal worth? ");
            int points = int.Parse(Console.ReadLine());


            if (goalType == 1)
            {
                SimpleGoal goal = new SimpleGoal(name, description, points);

                scoreKeeper.CreateGoal(goal);
            }

            else if (goalType == 2)
            {
                EternalGoal goal = new EternalGoal(name, description, points);

                scoreKeeper.CreateGoal(goal);
            }

            else if (goalType == 3)
            {
                Console.WriteLine("How many times do you want to complete this goal? ");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("How many bonus points when completed? ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

                scoreKeeper.CreateGoal(goal); 
            }

            else
            {
                Console.WriteLine("Invalid entry, please try again. "); 
            }

        }

        static void PromptRecordEvent(ScoreKeeper scoreKeeper)
        {
            Console.WriteLine("Which of the following goals did you complete?");
            Console.WriteLine(); 

            scoreKeeper.ListGoals(); 

            Console.WriteLine(); 
            Console.WriteLine("Please enter the corresponding number of the goal you completed: ");

            int goalNumber = int.Parse(Console.ReadLine());
            int goalIndex = goalNumber - 1; 

            scoreKeeper.RecordEvent(goalIndex); 
        }
    }
}




















/* TEST CODE */
        // SimpleGoal marathon = new SimpleGoal("Marathon", "Run 23 miles", 1000);
        // EternalGoal scripture = new EternalGoal("Read Scriptures", "Daily scripture study", 100);
        // ChecklistGoal temple = new ChecklistGoal("Attend Temple", "Do 12 temple sessions", 50, 10, 500);

        // scoreKeeper.CreateGoal(marathon);
        // scoreKeeper.CreateGoal(scripture);
        // scoreKeeper.CreateGoal(temple);

        // Console.WriteLine("Starting Goals:");
        // scoreKeeper.ListGoals();

        // Console.WriteLine(); 
        // Console.WriteLine("Recording Goals...");

        // scoreKeeper.RecordEvent(0);
        // scoreKeeper.DisplayScore(); 

        // scoreKeeper.RecordEvent(1);
        // scoreKeeper.DisplayScore(); 

        // scoreKeeper.RecordEvent(2);
        // scoreKeeper.DisplayScore(); 

        // Console.WriteLine(); 
        // Console.WriteLine("Goals after events:");
        // scoreKeeper.ListGoals();

