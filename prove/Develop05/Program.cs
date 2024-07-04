using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// W05 - Polymorphism Learning Activity
/// Created shape class
/// created Square, Rectangle and Circle class
/// created list of shapes and used for each loop to iterate through shaapes while displaying
/// </summary>
/// 

class Program
{
    static void Main(string[] args)

    {
        //create list of shapes
        List<Shape> shapes = new List<Shape>();

        //create new shapes
        Square square1 = new Square("Red", 3.0);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Blue", 3, 5);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle ("Green", 4);
        shapes.Add(circle1);


        //display shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($" {shape.Colour} {shape.GetType().Name.ToLower()} of area {shape.GetArea().ToString("0.00")}"); 
        }

       
    }
}
