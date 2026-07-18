using System;

class Program
{
    static void Main(string[] args)
    {
        ScoreKeeper scoreKeeper = new ScoreKeeper(); 
        
        SimpleGoal marathon = new SimpleGoal("Marathon", "Run 23 miles", 1000);
        
        EternalGoal scripture = new EternalGoal("Read Scriptures", "Daily scripture study", 100);
        
        ChecklistGoal temple = new ChecklistGoal("Attend Temple", "Do 12 temple sessions", 50, 10, 500);

        scoreKeeper.CreateGoal(marathon);
        scoreKeeper.CreateGoal(scripture);
        scoreKeeper.CreateGoal(temple);

        Console.WriteLine("Starting Goals:");
        scoreKeeper.ListGoals();

        Console.WriteLine(); 
        Console.WriteLine("Recording Goals...");

        scoreKeeper.RecordEvent(0);

        scoreKeeper.DisplayScore(); 

        scoreKeeper.RecordEvent(1);

        scoreKeeper.DisplayScore(); 

        scoreKeeper.RecordEvent(2);

        scoreKeeper.DisplayScore(); 

        Console.WriteLine(); 
        Console.WriteLine("Goals after events:");
        scoreKeeper.ListGoals();
    }
}


