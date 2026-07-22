using System; 

public abstract class Activity
{
    private string _date; 
    private int _minutes; 

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes; 
    }

    public string GetDate()
    {
        return _date; 
    }
    public int GetMinutes()
    {
        return _minutes; 
    }
    
    public virtual double GetDistance()
    {
        
    }

    public virtual double GetSpeed()
    {
        
    }

    public virtual double GetPace()
    {
        
    }

    public virtual string GetSummary()
    {
        
    }
}