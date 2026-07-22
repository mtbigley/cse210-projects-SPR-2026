using System; 

public class Activity
{
    private string _date; 
    private int _minutes; 
    private string _activityName;

    public Activity(string date, int minutes, string activityName)
    {
        _date = date;
        _minutes = minutes; 
        _activityName = activityName;
    }

    public string GetDate()
    {
        return _date; 
    }
    public int GetMinutes()
    {
        return _minutes; 
    }

    public string GetActivityName()
    {
        return _activityName; 
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_activityName} ({_minutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace {GetPace():F1} min per mile.";
    }
}