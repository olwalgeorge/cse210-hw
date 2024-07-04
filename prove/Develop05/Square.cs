using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Create Square 
/// </summary>
/// 

public class Square : Shape
{

    // fields
    private double _side;

    // constructor (colour is inherited from the base)
    public Square(string colour, double side) : base(colour)
    {
        _side = side;
    }

    // Methods (overrides the base method)
    public override double GetArea()
    {
        return _side * _side;
    }
}