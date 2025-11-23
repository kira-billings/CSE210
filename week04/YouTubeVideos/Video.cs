using System;
using System.Reflection;
using System.Transactions;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video()
    {
        
    }
    public void DisplayLength()
    {
        Console.WriteLine($"Length: {_length} seconds");
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.GetComment();
        }
    }
    public void DisplayNumberOfComments()
    {
        Console.WriteLine($"Number of Comments: {_comments.Count}");
    }
}