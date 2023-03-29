using System;

public class Event 
{
    private string eventTitle;
    private string eventDescription;
    private string data;
    private string time;
    private string address;
    private string type;
    
    public Event(string title, string description, string dataEvent, string timeEvent, string addressEvent)
    {
        eventTitle = title;
        eventDescription = description;
        data = dataEvent;
        time = timeEvent;
        address = addressEvent;
    }

    public string GetTitle()
    {
        return eventTitle;
    }
    public string GetDescription()
    {
        return eventDescription;
    }
    public string GetData()
    {
        return data;
    }
    public string GetTime()
    {
        return time;
    }
    public string GetAddress()
    {
        return address;
    }

    public void GetStandardInfo()
    {
        Console.WriteLine($"\nInfo event: {eventTitle} - {eventDescription}\nData event: {data} - {time}\nAddress: {address}");
    }

    public void ShortDescription(string typeEvent)
    {
        type = typeEvent;

        Console.WriteLine($"\nType of event: {typeEvent}\nTitle: {eventTitle}\nData: {data}");
    }
    
}