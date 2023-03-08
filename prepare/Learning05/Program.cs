using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        Square mySquare = new Square("red", 4);
        //mySquare.GetArea();
        //mySquare.GetColor();

        Rectangle myRectangle = new Rectangle("blue", 6, 4);
        //myRectangle.GetArea();

        Circle mycricle = new Circle("yellow", 7);

        List<Shape> _maths = new List<Shape>();
        _maths.Add(mySquare);
        _maths.Add(myRectangle);
        _maths.Add(mycricle);

        foreach (Shape shapes in _maths)
        {
            Console.Write(shapes.GetColor());
            Console.Write(shapes.GetArea());
        }
    }
}