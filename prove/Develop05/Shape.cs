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
    //fields
    private string _colour;

    //Getter and setter
    public string Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }

    //Constructor
    public Shape(string colour)
    {
        _colour = colour;
    }

    // Methods
    public virtual double GetArea()
    {
        return 0;
    }

}
    