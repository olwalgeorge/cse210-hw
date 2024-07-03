using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Create Shape Class
/// Add Colour property with its Getter and Setter
/// Add GetArea() method
/// </summary>
/// 

public class Shape
{
    private string _colour;

    public string Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }

    public Shape(string colour)
    {
        _colour = colour;
    }

    public virtual double GetArea()
    {
        return 0;
    }

}
    