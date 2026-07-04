using System; 

public class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }

    public void RunReflectionActivity()
    {
        StartActivity();

        int activityDuration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(activityDuration);

        while (DateTime.Now < endTime)
        {
            List<string> prompts = new List<string>()
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            
        }
    }
}