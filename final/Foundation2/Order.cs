using System;
using System.Collections.Generic;
using System.Reflection.Emit;

public class Order
{
    private List<Product> _products = new List<Product>(); 
    private Customer _customer; 

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products; 
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0.00;
        foreach (Product product in _products)
        {
            double perUnitCost = product.GetTotalCost();
            totalCost += perUnitCost; 
        }
        
        if (_customer.LivesInUSA())
        {
            totalCost += 5;
        }

        else
        {
            totalCost += 35; 
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: \n";
        packingLabel += "------------\n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} {product.GetProductID()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"{_customer.GetName()}\n{_customer.GetFullAddress()}";

        return shippingLabel;
    }
}