using System;
using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address; 
    private bool _livesInUSA; 

    public Customer(string name, Address address)
    {
        _name = name; 
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _livesInUSA;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}