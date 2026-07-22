using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("22 Jul 2026", 40, "Running", 5);

        Console.WriteLine(run.GetSummary());

        Cycling cycle = new Cycling("22 Jul 2026", 90, "Cycling", 20); 

        Console.WriteLine(cycle.GetSummary());

        
    }
}