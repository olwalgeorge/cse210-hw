using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// MeditationActivity class
/// Inherits from class Activity
/// Constructor method to initialize name and descrition
/// Execute() method to display meditation instructions calls Showspinner and displays focus message
/// </summary>

class MeditationActivity : Activity
{

    // Methods
    // Constructor to initialize name and description
    public MeditationActivity()
    {
        name = "Meditation";
        description = "This activity will guide you through a short meditation session to help you clear your mind and relax.";
    }

    // Execute() method to display meditation instructions calls Showspinner and displays focus message
    protected override void Execute()
    {
        Console.WriteLine("Find a comfortable position and close your eyes...");
        ShowSpinner(3);
        Console.WriteLine("Focus on your breath and let go of any thoughts...");
        ShowSpinner(duration);
    }
}
