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


    public void StartActivity()
    {
        // Intro message
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine("How long would you like your activity session (in seconds) to last?");
        /* string input = Console.ReadLine();
        _duration = int.Parse(input); */ // Nathan suggested a more elegant way to do this part, see below

        _duration = int.Parse(Console.ReadLine()); 

        Console.WriteLine();
        Console.WriteLine("Starting activity...");
    }

    // spinner time
    public void Spinner(int seconds)
    {
        List<string> spinners = new List<string>()
        {
            "|", "/", "-", "\\" // ran into a "newline in constant" error trying to enter "\" into the list, found the solution on a stack Overflow question that it needs to be doubled? "\\"? Gonna need to look into that more
        };

        // loop 
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


        /* Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character */ // copy pasted from the assignment suggestion-- gonna do some tinkering 
}