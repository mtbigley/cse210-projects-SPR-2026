using System; 

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target; 
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target; 
        _bonus = bonus; 
    }

    public override int RecordEvent()
    {
        if (IsComplete() == true)
        {
            return 0;
        }
        
        _amountCompleted++; 
        
        if (_amountCompleted == _target)
        {
            int finalPoints = GetPoints() + _bonus;
            return finalPoints;
        }

        else
        {
            int regularPoints = GetPoints(); 
            return regularPoints; 
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }

        else
        {
            return false; 
        }
    }

    public override string GetDetails()
    {
        string checkbox = "[ ]";

        if (IsComplete() == true)
        {
            checkbox = "[X]";
        }

        return $"{checkbox} {GetName()} ({GetDescription()}) Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }
}