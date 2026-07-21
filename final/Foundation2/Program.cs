using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Addresses
        Address addressMB = new Address("430 W 2nd S", "Rexburg", "ID", "USA");
        Address addressJS = new Address("440 E 2nd N", "Rexburg", "ID", "USA");
        Address addressFP = new Address("131 Cabildo Abierto", "Godoy Cruz", "Mendoza", "Argentina");

        // Customers
        Customer MichaelBigley = new Customer("Michael Bigley", addressMB);
        Customer JoeSchmoe = new Customer("Joe Schmoe", addressJS);
        Customer FernandoPanzacchi = new Customer("Fernando Panzacchi", addressFP);

        // Order 1 products
        Product mbsnack1 = new Product("Hot Cheetos", "0001", 10.99, 3);
        Product mbsnack2 = new Product("Walnuts", "0002", 14.99, 1);
        Product mbsnack3 = new Product("Gummy bears", "0003", 6.99, 1);

        // Order 2 products
        Product jssnack1 = new Product("Fritos", "0004", 9.99, 4);
        Product jssnack2 = new Product("Cheeze-its", "0005", 8.99, 2);
        Product jsproduct1 = new Product("Stainless-steel water bottle", "0006", 12.99, 1);

        // Order 3 products
        Product fpproduct1 = new Product("Mate Cocido", "0007", 15.99, 1);
        Product fpsnack1 = new Product("Alfajor", "0008", 5.99, 6);
        Product fpproduct2 = new Product("Bicicleta", "0009", 129.99, 1);

        // Product lists
        List<Product> productsMB = new List<Product>(); 
        List<Product> productsJS = new List<Product>();
        List<Product> productsFP = new List<Product>(); 

        
    }
}