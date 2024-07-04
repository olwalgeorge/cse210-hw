using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// Abstract Activity class
/// the fields defines duration, name and description protected properties than can be accessed by other classes
/// Start method clears screen, displays name and description of the activity and prompts user for duration. gets these parameters and calls the Execute methods, wait for its conclusion and calls End method
/// End method Displays completion message and calls ShowSpinner animates spinning for specified seconds.
/// The Execute method defines an abstract method to be implemented by each activity subclass
/// ShowCountdown method displays countdown for specified seconds
/// </summary>

abstract class Activity
{
    // Fields (Protected variables to be accessed by other clases)
    protected int duration;
    protected string name;
    protected string description;

    // Methods
    //start method
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {name} Activity");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        Execute();
        End();
    }

    // Execute method
    protected abstract void Execute();

    // End method
    protected void End()
    {
        Console.WriteLine("Good job!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {name} activity for {duration} seconds.");
        ShowSpinner(2);
    }

    // ShowSpinner method
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    // ShowCountdown method
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

