using System; 

public class Activity
{
    private string _activityName; 
    private string _activityDescription;
    private int _duration; // entered in seconds

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }


    public void startActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        
    }
}