using System; 

public class Activity
{
    private string _activityName; 
    private string _activityDescription;
    private int _duration; // entered in seconds, convert later

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }


    public void startActivity()
    {
        // Intro message
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine("How long would you like your activity session (in seconds) to last?");
        string input = Console.ReadLine();
        _duration = int.Parse(input);

        Console.WriteLine();
        Console.WriteLine("Starting activity...");
        // loading bar goes here
        
    }
}