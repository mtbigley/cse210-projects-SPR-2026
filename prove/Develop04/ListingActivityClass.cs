using System; 

public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public void RunListingActivity()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        //prompts and random selection thereof
        List<string> prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // select random prompt
        var RandomPrompt = new Random();
        int indexP = RandomPrompt.Next(prompts.Count);

        // display prompt 
        Console.WriteLine($"---{prompts[indexP]}---");
        Console.WriteLine($"Please use the next 10 seconds to consider the prompt and prepare to list answers.");
        Spinner(4); // buffer for user to read 
        Countdown(10); // countdown for user to think of answers

        // user lists items
        Console.WriteLine();
        Console.WriteLine("Please enter as many answers to the prompt as you can:");
        Console.WriteLine("Press enter while the field is blank to end early"); 
        
        // establish list of answers
        List<string> answers = new List<string>();
        
        while (DateTime.Now < endTime)
        { 
            string input = Console.ReadLine();
            
            // break on blank input
            if (input == "")
                {
                    break;
                }
            
            // add answer to list
            answers.Add(input);
        }
        
        Console.WriteLine("");
    }
}