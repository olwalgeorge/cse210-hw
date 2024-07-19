using System;

/// <author>
/// George Olwal
/// <summary>
/// Week 05 Develop: Eternal Quest Program/// 
/// The main entry point of the program.
/// </summary>
/// <param name="args">The command-line arguments.</param>
/// <remarks>
/// This programe creates, tracks different kind of goals grouped as, simple goals, eternal goals, checlist goals.
/// It uses abstract Goal class and child classes (SimpleGoal, EternalGoal, ChecklistGoal) to demonstrate concept of polymorpism in Object Orientented Programming.
/// Checklist class uses both method overiding and method overloading.
/// Bonus points have been added to realize creativity
/// </remarks>


class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
