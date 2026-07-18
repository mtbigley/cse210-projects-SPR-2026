using System; 

public class Rectangle : Shape
{
    private double _base;
    private double _height; 

    public Rectangle (string color, double rectangleBase, double height) : base(color)
    {
        _base = rectangleBase;
        _height = height; 
    }

    public override double GetArea()
    {
        return _base * _height;
    }
}