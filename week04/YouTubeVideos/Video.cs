using System;
using System.Collections.Generic;

public class Video
{
    // Member variables
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Add comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Return number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Display video details
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
        }

        Console.WriteLine(); // spacing
    }
}