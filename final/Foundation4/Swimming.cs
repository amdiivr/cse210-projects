using System;

public class Swimming : Activity
{
    private double length;
    private double laps;

    public Swimming(string data, double lengthInfo, double lapsInfo) : base(data)
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