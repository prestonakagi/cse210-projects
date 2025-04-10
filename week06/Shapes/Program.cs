using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("orange", 2.2);

        Rectangle rectangle = new Rectangle("green", 1.9, 4.1);
        
        Circle circle = new Circle("tan", 3.3);
        
        
        
        List<Shape> shapes = new List<Shape>(){};
        
        shapes.Add(square);
        
        shapes.Add(rectangle);
        
        shapes.Add(circle);
        
        
        
        foreach (Shape shape in shapes)
        
        {
        
        string colorOfShape = shape.GetColor();
        
        double areaOfShape = shape.GetArea(); // will use each child class's respective GetArea() method.
        
        
        
        Console.WriteLine($"{colorOfShape}, area = {areaOfShape}");
        
        }
    }
}