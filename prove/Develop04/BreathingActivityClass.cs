using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing" /* name */, "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing." /* activity description */)
    {
        
    }

    public void RunBreathingActivity()
    {
        StartActivity();

        DateTime currentTime = DateTime.Now;
        int activityDuration = GetDuration();
        DateTime endTime = currentTime.AddSeconds(activityDuration);

        if (currentTime < endTime)
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            Console.WriteLine("Breathe out...");
            Countdown(6);
        }
        EndActivity();
    }
}