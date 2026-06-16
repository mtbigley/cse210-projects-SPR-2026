using System;

class Program
{
    static void Main(string[] args)
    {
        // Introduce program to user
        Console.WriteLine("Hello, I'm a grades calculator designed to help you determine your letter grade and whether or not you passed your class!");
        
        // Retrieve and store percentage
        Console.WriteLine("First things first, I'll need your final grade percentage.");
        string grade = Console.ReadLine();

        // Parse into useable integer
        int gradePercentage = int.Parse(grade);

        // initialize final letter grade variable
        string finalGrade = "";

        // determine letter grade and message

        // A+ at 95% and up
        if (gradePercentage > 94.9)
        {
            finalGrade = "A+";
            Console.WriteLine("You got an A+! Congrats on your hard work!");
        } 

        // A at 90% and up 
        else if (gradePercentage > 89.9)
        {
            finalGrade = "A";
            Console.WriteLine("You got an A! Give yourself a round of applause!");
        }

        // B+ at 85% and up
        else if (gradePercentage > 84.9)
        {
            finalGrade = "B+";
            Console.WriteLine("You got a B+! Good work!");
        }

        // B at 80% and up
        else if (gradePercentage > 79.9)
        {
            finalGrade = "B";
            Console.WriteLine("You got a B! Well done!");
        }

        // C+ at 75% and up
        else if (gradePercentage > 74.9)
        {
            finalGrade = "C+"; 
            Console.WriteLine("You got a C+. You passed!");
        }

        //  C at 70% and up 
        else if (gradePercentage > 69.9)
        {
            finalGrade = "C";
            Console.WriteLine("You got a C. You passed! Consider retaking or studying more to keep the concepts fresh and sharp for your next courses!");
        }

        // D+ at 65% and up
        else if (gradePercentage > 64.9)
        {
            finalGrade = "D+"; 
            Console.WriteLine("You got a D+. You'll have to retake the class but you're almost there!");
        }

        // D at 60% and up
        else if (gradePercentage > 59.9)
        {
            finalGrade = "D";
            Console.WriteLine("You got a D. You'll have to retake the class but you're almost there, just a little more study!");
        }

        // F at below 60%
        else
        {
            finalGrade = "F";
            Console.WriteLine("You failed unfortunately. Study and work hard, you'll pass next time I'm sure!");
        }

        // Print final letter grade for user
        Console.WriteLine($"Your final letter grade came out to {finalGrade}");
    }
}