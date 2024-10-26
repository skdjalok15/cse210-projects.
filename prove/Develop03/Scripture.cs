using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Randomly hide a specified number of words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        // Ensure we don't hide more words than are visible
        int hideCount = Math.Min(numberToHide, visibleWords.Count);
        for (int i = 0; i < hideCount; i++)
        {
            visibleWords[random.Next(visibleWords.Count)].Hide();
        }
    }

    // Get the full scripture text with some words hidden
    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}: {text}";
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
