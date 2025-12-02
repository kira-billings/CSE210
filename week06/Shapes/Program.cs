using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Circle circle = new Circle(3.45, "blue");
        shapes.Add(circle);
        Rectangle rectangle = new Rectangle(10, 5, "yellow");
        shapes.Add(rectangle);
        Square square = new Square(3.77, "red");
        shapes.Add(square);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
        
       
        
    }
}