using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// W03 Prepare: Learning Activity
/// Create a Fraction class
/// Create the Constructors
/// Create the Getters and Setters
/// Create methods to return the representations
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction(); // instantiate with default values (1/1)
        Fraction fract2 = new Fraction(5); // instantiate with whole number
        Fraction fract3 = new Fraction(3, 4); // instantiate with fraction (3/4)
        Fraction fract4 = new Fraction(1, 3); // Instatantiate with fraction (1/3)

        //Dispaly through method calls
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetDecimalValue());
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue());
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetDecimalValue());
        Console.WriteLine(fract4.GetFractionString());
        Console.WriteLine(fract4.GetDecimalValue());
        
    }
}