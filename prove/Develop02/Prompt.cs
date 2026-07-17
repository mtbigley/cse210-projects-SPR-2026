using System;

public class Prompt
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are you most grateful for today?",
        "What was the most beautiful part of nature you saw today?",
        "Do you have anything you regret not doing today?",
        "What are you excited about for tomorrow?",
        "What worries did you carry with you today that you could do better leaving behind?"
    };
    
    public string GetPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}