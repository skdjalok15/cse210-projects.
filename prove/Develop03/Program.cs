using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Multiple scripture options for exceeding core requirements
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths.")
        };

        Console.WriteLine("Choose a scripture to memorize:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetDisplayText()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        Scripture scripture = scriptures[choice];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Asking the user how many words to hide (exceeds requirements)
            Console.WriteLine("How many words would you like to hide?");
            int wordsToHide = int.Parse(Console.ReadLine());

            scripture.HideRandomWords(wordsToHide);
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. You've memorized the scripture!");
    }
}
