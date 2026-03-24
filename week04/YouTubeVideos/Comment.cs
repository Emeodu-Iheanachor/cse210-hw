using System;

public class Comment
{
    // Member variables (underscoreCamelCase)
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Methods
    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}