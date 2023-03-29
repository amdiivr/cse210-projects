using System;

public class OutdoorGathering : Event
{
    private int weatherBroadcast;

    public OutdoorGathering(string title, string description, string dataEvent, string timeEvent, string addressEvent, int weather) : base(title, description, dataEvent, timeEvent, addressEvent)
    {
        weatherBroadcast = weather;
    }

    public int GetWeatherInfo()
    {
        return weatherBroadcast;
    }
}
