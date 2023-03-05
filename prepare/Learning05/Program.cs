using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square area1 = new Square("Blue", 5);
        shapes.Add(area1);

        Rectangle area2 = new Rectangle("Black", 3, 8);
        shapes.Add(area2);

        Circle area3 = new Circle("Grey", 12);
        shapes.Add(area3);

        foreach (Shape areaShape in shapes)
        {
            string color = areaShape.GetColor();

            double area = areaShape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}