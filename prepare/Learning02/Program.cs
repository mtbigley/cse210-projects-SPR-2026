using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job = new Job(); 
        job._jobTitle = " ooblar ";
        job._company = "blarblar";

        Job job2 = new Job(); 
        job2._jobTitle = "blargablarg";
        job2._company = "floogaboogla";

        job.DisplayJobDetails();
        job2.DisplayJobDetails();

        // Console.WriteLine($"{job._jobTitle}");
        // Console.WriteLine($"{job2._jobTitle}");
    }
}