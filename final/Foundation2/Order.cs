using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>(); 
    private Customer _customer; 

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
    }
}