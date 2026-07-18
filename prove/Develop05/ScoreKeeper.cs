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
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(); // time to write a getter
        }
    }
}