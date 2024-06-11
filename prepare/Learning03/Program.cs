using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// W03 Prepare: Learning Activity
/// Create a Fraction class
/// Create the Constructors
/// Create the Getters and Setters
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction(); // instantiate with default values (1/1)
        Fraction fract2 = new Fraction(6); // instantiate with whole number
        Fraction fract3 = new Fraction(6, 7); // instantiate with fraction (6/7)

        //Test getters
        Console.WriteLine($"Fraction 3: {fract3.GetTop()}/{fract3.GetBottom()}");

        //Test setters
        fract3.SetTop(8);
        fract3.SetBottom(9);
        Console.WriteLine($"Fraction 3: {fract3.GetTop()}/{fract3.GetBottom()}");
        
    }
}