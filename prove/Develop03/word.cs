public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // By default, the word is not hidden
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get the word text or underscores if hidden
    public string GetDisplayText()
    {
        return _isHidden ? "____" : _text;
    }
}
