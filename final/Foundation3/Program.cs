using System;

class Program
{
    static void Main(string[] args)
    {
        /* Test code */

        // Address
        Address addressMont = new Address("7 Mercedes ct.", "Seaside", "CA", "USA");

        // Events
        Lecture lecture1 = new Lecture("The human experience", "A lecture on the human experience", "July 21, 2026", "6:00 PM", addressMont, "Dr. Mikey B.", 20);
        Reception reception1 = new Reception("Eardley Wedding Reception", "Savannah Eardley is getting married.", "September 9th, 2026", "7:00pm", addressMont, "jtsinid@yahoo.com");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Neighborhood barbeque", "a neighborhood barbeque for all the residents at providence square", "July 24, 2026", "5:00pm", addressMont, "Sunny, Hot, Partially cloudy.");

        Console.WriteLine("Standard Details: ");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details: ");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details: ");
        Console.WriteLine(outdoorGathering1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        Console.WriteLine(outdoorGathering1.GetShortDescription());
        Console.WriteLine();
    }
}

