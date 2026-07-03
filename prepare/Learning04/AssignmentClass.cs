using System;
using System.Security.Cryptography.X509Certificates;

public class Assignment
{
    // Member variables 
    private string _studentName; 
    private string _topic; 

// Constructor
    public Assignment (string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic; 
    }
 // Method
    public string GetSummary()
    {
        string summaryText = $" {_studentName} - {_topic}";
        return summaryText;
    }
    

}