using System;
using System.Collections.Generic;

/// <summary>
/// BreathingActivity
/// </summary>
class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void Execute()
    {
        int interval = duration / 20;
        for (int i = 0; i < interval; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(10);
            Console.WriteLine("Breathe out...");
            ShowCountdown(10);
        }
    }
}
