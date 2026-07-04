using System; 

public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public void RunListingActivity()
    {
        StartActivity();

        int activityDuration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(activityDuration + 10);

        //prompts and random selection thereof
        List<string> prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        var RandomPrompt = new Random();
        int indexP = RandomPrompt.Next(prompts.Count);

        Console.WriteLine($"---{prompts[indexP]}---");
        Console.WriteLine($"Please consider the prompt and prepare to list answers.");
        Countdown(10);




        Console.WriteLine("");
    }
}