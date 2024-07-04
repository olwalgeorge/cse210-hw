using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Circle Class
/// </summary>
/// 

public class Circle : Shape
{       
    //Fields
    private double _radius;


    // Constructor (colour is inherited from the base)
    public Circle(string colour, double radius) : base(colour)
    {
        _radius = radius;
    }


    //Methods (overrides the base method)
    public override double GetArea()
    
    {
        return Math.PI * _radius * _radius;
    }

}