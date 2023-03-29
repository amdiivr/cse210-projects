using System;

public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, string dataEvent, string timeEvent, string addressEvent, string speakerPerson, int totalCapacity) : base(title, description, dataEvent, timeEvent, addressEvent)
    {
        speaker = speakerPerson;
        capacity = totalCapacity;
    }

    public string GetLecture()
    {
        return "Speaker: " + speaker + "\nCapacity: " + capacity + " people";
    }

}