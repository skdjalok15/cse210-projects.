using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding your breathing.", 60) { }

    public void Run()
    {
        DisplayStartingMessage();
        SetCustomDuration();

        for (int i = 0; i < _duration / 10; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine("Hold...");
            ShowCountDown(4);
            Console.Write("Breathe out... ");
            ShowCountDown(4);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
