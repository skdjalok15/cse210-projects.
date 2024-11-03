using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds.\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nYou have completed the {_name} activity. Well done!\n");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Creative extension: allowing users to select a custom duration.
    public void SetCustomDuration()
    {
        Console.WriteLine("Would you like to set a custom duration for this activity? (yes/no)");
        string response = Console.ReadLine().ToLower();
        if (response == "yes")
        {
            Console.Write("Enter the custom duration in seconds: ");
            int customDuration;
            if (int.TryParse(Console.ReadLine(), out customDuration) && customDuration > 0)
            {
                _duration = customDuration;
                Console.WriteLine($"Duration set to {_duration} seconds.\n");
            }
            else
            {
                Console.WriteLine("Invalid input. Using default duration.\n");
            }
        }
    }
}
