using System;

public class Running : Activity
{
    private double numberLaps;
    private double length;
    public Running(string data, double lengthInfo, double laps) : base(data)
    {
        numberLaps = laps;
        length = lengthInfo;
    }

    public override double GetDistance()
    {
        return numberLaps * 50 / 100;
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