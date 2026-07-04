using System; 

public class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }

    public void RunReflectionActivity()
    {
        StartActivity();

        Console.WriteLine("Consider the following prompt:");

        int activityDuration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(activityDuration);

        // lists of prompts and questions
        List<string> prompts = new List<string>()
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

        List<string> questions = new List<string>()
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

        // Random number generators for prompt and question indices 
        var randomPrompt = new Random(); // interesting that random cannot be implicitly forced into an int variable type-- another useage of var from stack overflow here
        var randomQuestion = new Random(); 

        // display prompt text
        int indexP = randomPrompt.Next(prompts.Count);
        Console.WriteLine($"----{prompts[indexP]}----");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Spinner(2);

        // Display reflection questions at 10s intervals with spinner
        while (DateTime.Now < endTime && questions.Count > 0)
        {
            int indexQ = randomQuestion.Next(questions.Count);
            Console.WriteLine(questions[indexQ]);
            questions.RemoveAt(indexQ);
            Spinner(10);
        }
        Spinner(2);
        EndActivity();
    }
}