using System; 

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, string activityName, double speed) : base(date, minutes, activityName) 
    {
        _speed = speed; 
    }

    public override double GetDistance()
    {
        return _speed * (GetMinutes() / 60); 
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed; 
    }
}