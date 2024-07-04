using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// ReflectionActivity class
/// Inherits from Activity and helps users reflect on past experiences.
/// Execute method that does the following
/// Randomly selects prompts and questions for reflection.
/// Displays the selected prompt and questions to the user one by one with a spinner effect.
/// </summary>

class ReflectionActivity : Activity
{
    private static List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private static List<string> usedPrompts = new List<string>();
    private static List<string> usedQuestions = new List<string>();

    public ReflectionActivity()
    {
        name = "Reflection";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    protected override void Execute()
    {
        Random random = new Random();
        if (usedPrompts.Count == prompts.Count)
            usedPrompts.Clear();
        string prompt;
        do
        {
            prompt = prompts[random.Next(prompts.Count)];
        } while (usedPrompts.Contains(prompt));
        usedPrompts.Add(prompt);
        Console.WriteLine(prompt);
        ShowSpinner(3);

        if (usedQuestions.Count == questions.Count)
            usedQuestions.Clear();
        int interval = duration / questions.Count;
        foreach (var question in questions)
        {
            if (usedQuestions.Contains(question))
                continue;
            usedQuestions.Add(question);
            Console.WriteLine(question);
            ShowSpinner(interval);
        }
    }
}
