using System;
/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// W03 Prepare: Learning Activity
/// Create a Fraction class
/// Create the Constructors
/// Create Gettors
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
        
    }

    //Constructor - sets whole nuumber (numerator/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
       
    }

    //Constructor - sets fraction (numerator/denominator)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        
    }

    //Getter (numerator)
    public int GetTop()
    {
        return _top; 
    }

    //Getter (denominator)
    public int GetBottom()
    {
        return _bottom;
    }

    //Setter (numerator)
    public void SetTop(int top)
    {
        _top = top;
    }

    //Setter (denominator)
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


}






