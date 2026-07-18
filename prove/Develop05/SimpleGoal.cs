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

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetails()
    {
        string checkbox = "[ ]";

        if (_isComplete == true)
        {
            checkbox = "[X]";
        }

        return $"{checkbox} {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}