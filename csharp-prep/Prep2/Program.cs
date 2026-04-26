using System;

class Program
{
    static void Main(string[] args)
    {
        // input into variable
        Console.Write("What is your grade percentage? "); 
        string mtb_input_Num_Grade = Console.ReadLine();

        // parse into string
        int mtb_Num_Grade = int.Parse(mtb_input_Num_Grade);

        // establish letter grade variable
        string mtb_Let_Grade; 
        
        // if statements to determine letter grade variable
        if (mtb_Num_Grade >= 90)
        {
            mtb_Let_Grade = "A";
        }
        else if (mtb_Num_Grade >= 80)
        {
            mtb_Let_Grade = "B";
        }
        else if (mtb_Num_Grade >= 70)
        {
            mtb_Let_Grade = "C";
        }
        else if (mtb_Num_Grade >= 60)
        {
            mtb_Let_Grade = "D";
        }
        else
        {
            mtb_Let_Grade = "F";
        }

        // print letter grade variable to user
        Console.WriteLine($"Your grade is: {mtb_Let_Grade}");

        // pass/fail
        if (mtb_Num_Grade >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass. Try again next time!");
        }
    }
}