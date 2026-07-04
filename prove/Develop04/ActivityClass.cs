using System; 

public class Activity
{
    private string _activityName; 
    private string _activityDescription;
    private int _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public void StartActivity()
    {
        // Intro message
        Console.Clear();
        Spinner(1);
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Spinner(2);
        Console.WriteLine("How long would you like your activity session (in seconds) to last?");

        /* string input = Console.ReadLine();
        _duration = int.Parse(input); */ 
        
        // Nathan suggested a more elegant way to do this part, see below

        _duration = int.Parse(Console.ReadLine()); 

        Console.WriteLine();
        Console.WriteLine("Starting activity...");
        Spinner(3);
    }

    // spinner 
    public void Spinner(int seconds)
    {
        List<string> spinners = new List<string>()
        {
            "|", "/", "-", "\\" // ran into a "newline in constant" error trying to enter "\" into the list, found the solution on a stack Overflow question that it needs to be doubled? "\\"? Gonna need to look into that more
        };

        // spinner loop 
        var startTime = DateTime.UtcNow; 
        while(DateTime.UtcNow - startTime < TimeSpan.FromSeconds(seconds))
        {
            foreach (string symbol in spinners)
            {
                Console.Write(symbol); 
                Thread.Sleep(300);
                Console.Write("\b \b");   
            }
        }
    }

    // Countdown
    public void Countdown (int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    // Ending activity
    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done :]");
        Spinner(2);
        Console.WriteLine($"You've completed {_duration} seconds of the {_activityName} activity.");
    }

    // duration getter
    public int GetDuration()
    {
        return _duration;
    }
}

      