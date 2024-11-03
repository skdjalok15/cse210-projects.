using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a challenge.",
        "Recall a moment you felt truly proud of yourself.",
        "Remember a time you helped someone in need."
    };

    private List<string> _questions = new List<string>
    {
        "How did this experience affect you?",
        "What did you learn from it?",
        "How can you apply this lesson in the future?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity encourages deep thought about personal experiences.", 60) { }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetCustomDuration();
        
        Console.WriteLine("Prompt: " + GetRandomPrompt());
        ShowSpinner(3);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Question: " + GetRandomQuestion());
            Console.WriteLine("Reflect on this question... (Press Enter when ready)");
            Console.ReadLine();
        }

        DisplayEndingMessage();
    }
}
