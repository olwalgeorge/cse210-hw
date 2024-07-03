using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// W05 - Polymorphism Learning Activity
/// </summary>
/// 

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 3.0);

        Console.WriteLine($"The area of the {square1.Colour} square is {square1.GetArea()}");

        Rectangle rectangle1 = new Rectangle("blue", 3.5, 6.3);

        Console.WriteLine($"The area of the {rectangle1.Colour} rectangle is {rectangle1.GetArea()}");

    }
}
