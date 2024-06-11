using System;
/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// W03 Prepare: Learning Activity
/// Create a Fraction class
/// Create the Constructors
/// </summary>



public class Fraction
{   
    //Fields (private)
    private int _top;
    private int _bottom;

    // Constructor - initialize with(1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;  
        Console.WriteLine("Constructor called with default values"); // For verification at this stage      
    }

    //Constructor - sets whole nuumber (numerator/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
        Console.WriteLine($"Constructor called with whole number, {_top}"); //For verication only
    }

    //Constructor - sets fraction (numerator/denominator)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        Console.WriteLine($"Constructor called with numerator, {_top} and denominator, {_bottom}");// for verification
    }

}






