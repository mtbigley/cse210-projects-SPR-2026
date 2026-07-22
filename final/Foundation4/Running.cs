using System; 

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, string activityName, double distance) : base(date, minutes, activityName) 
    {
        _distance = distance; 
    }

    public override double GetDistance()
    {
        return _distance; 
    }

    public override double GetSpeed()
    {
        
    }

    public override double GetPace()
    {
        
    }
}