using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Square testsquare = new Square("Blue", 5); 
        Circle testcircle = new Circle("Red", 14);
        Rectangle testrectangle = new Rectangle ("Purple", 3, 5);

        List<Shape> shapes = new List<Shape>(); 

        shapes.Add(new Square("blue", 5));
        shapes.Add(new Circle("green", 7));
        shapes.Add(new Rectangle("purple", 3, 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}"); 
        }
    }
}

// Console.WriteLine(testsquare.GetArea());
// Console.WriteLine(testsquare.GetColor());

// Console.WriteLine(testcircle.GetArea());
// Console.WriteLine(testcircle.GetColor());

// Console.WriteLine(testrectangle.GetArea());
// Console.WriteLine(testrectangle.GetColor());