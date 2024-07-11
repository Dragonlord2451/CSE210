using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public override string ToString()
    {
        int minutes = Length / 60;
        int seconds = Length % 60;
        return $"Title: {Title}\nAuthor: {Author}\nLength: {minutes} minutes, {seconds} seconds\nComments ({NumberOfComments()}):";
    }
}
