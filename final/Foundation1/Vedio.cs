using System;
using System.Collections.Generic;

// Class representing a video
public class Video
{
    // Properties
    public string Title { get; private set; }     // Title of the video
    public string Author { get; private set; }    // Author of the video
    public int Length { get; private set; }       // Length of the video in seconds
    private List<Comment> _comments;               // List to store comments

    // Constructor to initialize the video properties
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        _comments = new List<Comment>(); // Initialize the comments list
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return _comments.Count; // Returns the count of comments
    }

    // Method to retrieve all comments
    public List<Comment> GetComments()
    {
        return _comments; // Return the list of comments
    }
}
