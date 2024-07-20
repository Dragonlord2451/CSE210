using System;

public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity)
        : base(title, description, dateTime, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string FullDetails()
    {
        return StandardDetails() + $"\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }

    public override string ShortDescription()
    {
        return $"Type: Lecture\nTitle: {Title}\nDate: {DateTime.ToString("MMMM dd, yyyy")}";
    }
}
