using System;
using System.Drawing;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Rectangle class
/// </summary>
/// 

public class Rectangle : Shape
{    
    // fields
    private double _length;
    private double _width;

    // constructor (colour is inherited from the base)
    public Rectangle(string colour, double length, double width) : base(colour)
    {
        
        _length = length;
        _width = width;

    }

    // methods (overrides the GetArea() method of the base)
    public override double GetArea()
    {
        return _length * _width;
    }
}