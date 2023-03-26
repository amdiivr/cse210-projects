using System;

public class Video 
{
    public string title;
    public string author;
    public int length;
    public List<Comments> infoComments = new List<Comments>();

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nName of video: '{title}'");
        Console.WriteLine($"Author: '{author}'");
        Console.WriteLine($"Time: {length} seconds");

        foreach (Comments infoComment in infoComments)
        {
            infoComment.ShowFullComments();
        }
    }
    
}