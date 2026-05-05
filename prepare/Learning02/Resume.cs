using System; 
using System.Collections.Generic;

public class Resume
{
    public string _mtb_name; 

    public List<Job> _jobs = new List<Job>();

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_mtb_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails(); 
        }
    }
}