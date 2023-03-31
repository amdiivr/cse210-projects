using System;

public class StationaryBike : Activity
{
    private double length;
    private double laps;
    public StationaryBike(string data, double lengthInfo, double lapsInfo) : base(data)
    {
        length = lengthInfo;
        laps = lapsInfo;
    }

    public override double GetDistance()
    {
        return laps * 50 / 100;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / length) * 60;
    }
    public override double GetPace()
    {
        return length / GetDistance();
    }
}