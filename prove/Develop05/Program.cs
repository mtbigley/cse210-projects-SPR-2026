/* Exceeding requirements
Most of what I did to exceed requirements for this program was implementing things like UI smoothing and user-error catches to prevent program crashes. 
Instead of crashing the program altogether, most of the time where the user is concerned if they make a mistake or typo, the program simply returns to the main menu and allows
the user to try again after telling them they've entered an invalid input. 
I'd like to come back and maybe implement functionality to where the user can specify the name of their save file so that the program could handle multiple user's data of goals and
progress, but for now I want to move on to my final project. */ 

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
                scoreKeeper.SaveGoals("goals.txt");

                Console.WriteLine("Goals saved."); 
                Console.WriteLine("Press Enter to return to the main menu.");
                Console.ReadLine();

            }

            else if (input == 5)
            {
                scoreKeeper.LoadGoals("goals.txt");

                Console.WriteLine("Goals loaded.");
                Console.WriteLine("Press Enter to return to the main menu.");
                Console.ReadLine();

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

            if (goalType < 1 || goalType > 3)
            {
                Console.WriteLine("Invalid entry, press enter to try again. "); 
                Console.ReadLine(); 
                return;
            }

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

            Console.WriteLine("Goal Created. Press Enter to continue.");
            Console.ReadLine(); 
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