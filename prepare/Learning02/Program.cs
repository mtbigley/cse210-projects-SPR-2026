using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); 
        job1._mtb_company = "nvidia";
        job1._mtb_job_title = "engineer";
        job1._mtb_start_year = 2027;
        job1._mtb_end_year = 2032;

        Job job2 = new Job(); 
        job2._mtb_company = "amazon";
        job2._mtb_job_title = "engineer";
        job2._mtb_start_year = 2027;
        job2._mtb_end_year = 2032;

        Resume mtb_Resume = new Resume(); 
        mtb_Resume._mtb_name = "Michael Bigley";

        mtb_Resume._jobs.Add(job1);
        mtb_Resume._jobs.Add(job2); 

        mtb_Resume.DisplayJobDetails(); 
        
    }
}