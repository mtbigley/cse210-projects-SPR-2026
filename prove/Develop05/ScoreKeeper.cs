using System; 

public class ScoreKeeper
{
    private List<Goal> _goals = new List<Goal>(); 
    private int _score; 

    public ScoreKeeper()
    {
        _score = 0;
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoals()
    {
        Console.WriteLine();
        int goalDisplayNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalDisplayNumber}. {goal.GetDetails()}");
            goalDisplayNumber ++; 
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0)
        {
            Console.WriteLine("Invalid entry-- please try again."); 
            return; 
        }

        else if (goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid entry-- please try again.");
            return; 
        }

        else
        {
        Goal goal = _goals[goalIndex];

        int pointsEarned = goal.RecordEvent();

        _score += pointsEarned; 

        Console.WriteLine($"Good job completing {goal.GetName()}! You just earned {pointsEarned} points.");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename) // this one took me a lot of research and a lot of testing/tweaking to get exactly where I wanted it-- mostly from this page: https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-read-a-text-file-in-C-Sharp/
    {
        string[] lines = File.ReadAllLines(filename); 

        _score = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1)) // had to learn how to skip the first line since the first line in the txt file is the score. https://stackoverflow.com/questions/52225433/skip-lines-by-using-streamreader
        {
            string[] parts = line.Split("|"); // reused this from Develop02

            string type = parts[0]; // Goal type identifier in the txt file

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points);

                if (complete == true)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal); 
            }

            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);

                _goals.Add(goal); 
            }

            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int _amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

                for (int i = 0; i < _amountCompleted; i++)
                {
                    goal.RecordEvent(); 
                }

                _goals.Add(goal); 
            }
        }
    }
}