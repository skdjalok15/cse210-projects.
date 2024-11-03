using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List things you are grateful for.",
        "List things that make you happy.",
        "List things you want to achieve today."
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect by listing items.", 45) { }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetCustomDuration();
        
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Start listing items: (Press Enter after each item, type 'done' to finish)");

        List<string> items = new List<string>();
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.\n");
        DisplayEndingMessage();
    }
}
