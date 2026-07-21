using System;
using System.Net.Sockets;

public abstract class Event
{
    private string _title; 
    private string _description; 
    private string _date; 
    private string _time; 
    private Address _address; 

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date; 
        _time = time; 
        _address = address; 
    }

    public string GetStandardDetails()
    {
        
    }

    public string GetFullDetails()
    {
        
    }

    public string GetShortDescription()
    {
        return _description; 
    }
}