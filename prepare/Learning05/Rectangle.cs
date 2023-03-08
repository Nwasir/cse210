using System;
public class Rectangle : Shape
{
    public double _length;
    public double _width;

    public Rectangle (string color, int length, int width) : base (color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }

}