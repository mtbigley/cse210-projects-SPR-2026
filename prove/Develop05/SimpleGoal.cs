using System; 

public class SimpleGoal : Goal
{
    private bool _isComplete; 

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        // inherets everything it needs 
    }

    public override int RecordEvent()
    {
        if (_isComplete == true)
        {
            return 0; //no points if already completed
        }

        else _isComplete = true; 
        return GetPoints(); 
    }
}