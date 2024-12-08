// Class representing a comment
public class Comment
{
    // Properties
    public string Name { get; private set; }  // Name of the commenter
    public string Text { get; private set; }  // Text of the comment

    // Constructor to initialize comment properties
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}
