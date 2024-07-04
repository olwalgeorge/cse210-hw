using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// BreathingActivity
/// Initializes the name and description of the activity
/// Executive() method displays breath in and out messages along with countdown for each action
/// </summary>
class BreathingActivity : Activity
{

    // Methods
    // Constructor to name and description
    public BreathingActivity()
    {
        name = "Breathing";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Execute() method displays breath in and out messages along with countdown for each action
    protected override void Execute()
    {
        int interval = duration / 10;
        for (int i = 0; i < interval; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("Breathe out...");
            ShowCountdown(5);
        }
    }
}
