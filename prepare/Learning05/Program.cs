using System;

class Program
{
    static void Main(string[] args)
    {

        Square aSquare = new Square("blue", 4);
        Rectangle aRectangle = new Rectangle("green", 4, 5);
        Circle aCircle = new Circle("red", 5);

        /*
        Console.WriteLine(aSquare.Color);
        Console.WriteLine(aSquare.GetArea());
        Console.WriteLine();

        
        Console.WriteLine(aRectangle.Color);
        Console.WriteLine(aRectangle.GetArea());
        Console.WriteLine();

        
        Console.WriteLine(aCircle.Color);
        Console.WriteLine(aCircle.GetArea().ToString("#.##"));
        Console.WriteLine();
        */

        List<Shape> shapes = new List<Shape>();
        shapes.Add(aSquare);
        shapes.Add(aRectangle);
        shapes.Add(aCircle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Color);
            Console.WriteLine(shape.GetArea().ToString("0.00"));
            Console.WriteLine();
        }

    }
}