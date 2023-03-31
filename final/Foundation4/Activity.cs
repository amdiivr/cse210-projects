using System;

public class Activity
{
    private string data;
    private double distance;
    private double speed;
    private double pace;

    public double GetDistanceInfo(double distanceInfo)
    {
        distance = distanceInfo;
        return distance;
    }
    public double GetSpeedInfo(double speedInfo)
    {
        speed = speedInfo;
        return speed;
    }
    public double GetPaceInfo(double paceInfo)
    {
        pace = paceInfo;
        return pace;
    }
    public Activity(string dataInfo)
    {
        data = dataInfo;    
    }

    public virtual double GetDistance()
    {
        return distance;
        // return numberOfLaps * 50 / 1000;
    }
    public virtual double GetSpeed()
    {
        return speed;
    }
    public virtual double GetPace()
    {
        return pace;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{data}: Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km.");
    }
}