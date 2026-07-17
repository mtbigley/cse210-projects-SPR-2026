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

    public string GetSummary()
    {
        string summaryText = $"{_studentName} - {_topic}";
        return summaryText;
    }
    
    public string GetStudentName()
    {
        return _studentName;
    }
}