using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string mtb_fName = Console.ReadLine(); 

        Console.Write("What is your laste name? ");
        string mtb_lname = Console.ReadLine();

        string mtb_sentence = mtb_lname + ", " + mtb_fName + " " + mtb_lname;

        Console.Write("Your name is " + mtb_sentence + ".");
    }
}