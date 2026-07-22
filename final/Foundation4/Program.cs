using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("22 Jul 2026", 40, "Running", 5);
        Cycling cycle = new Cycling("22 Jul 2026", 90, "Cycling", 20); 
        Swimming swim = new Swimming("23 Jul 2026", 30, "Swimming", 40); 

        List<Activity> activities = new List<Activity>(); 

        activities.Add(run);
        activities.Add(cycle); 
        activities.Add(swim); 

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}