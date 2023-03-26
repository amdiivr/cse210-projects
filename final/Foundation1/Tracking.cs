using System;

public class Tracking
{
    public string numberVideo;

    public List<Video> infoVideo = new List<Video>();
   

    public void DisplayTotalInfo()
    {
        Console.WriteLine($"\n{numberVideo}:");

        foreach (Video info in infoVideo)
        {
            info.DisplayVideoInfo();    
        }
    }
}