using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// Abstract Activity class
/// </summary>

abstract class Activity
{
    protected int duration;
    protected string name;
    protected string description;

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

    protected abstract void Execute();

    protected void End()
    {
        Console.WriteLine("Good job!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {name} activity for {duration} seconds.");
        ShowSpinner(2);
    }

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

