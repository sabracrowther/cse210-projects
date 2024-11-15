using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square  square = new Square("red", 3);
        
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rec1 = new Rectangle("blue", 5, 2);
        Console.WriteLine(rec1.GetColor());
        Console.WriteLine(rec1.GetArea());

        Circle circle = new Circle("purple", 4);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rec1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }




    }
}