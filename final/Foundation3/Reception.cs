using System;

public class Reception : Event
{
    private string RSVP;

    public Reception(string title, string description, string dataEvent, string timeEvent, string addressEvent, string RSVPemail) : base(title, description, dataEvent, timeEvent, addressEvent)
    {
        RSVP = RSVPemail;
    }

    public string GetReception()
    {
        return "RSVP: " + RSVP;
    }
}