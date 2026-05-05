using System; 

public class Job
{
    public string _mtb_job_title; 
    public string _mtb_company; 
    public int _mtb_start_year; 
    public int _mtb_end_year; 

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_mtb_job_title} ({_mtb_company}) {_mtb_start_year} - {_mtb_end_year}");
    }
}