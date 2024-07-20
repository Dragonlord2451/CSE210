using System;

public abstract class Event
{
    private string title;
    private string description;
    private DateTime dateTime;
    private Address address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        this.title = title;
        this.description = description;
        this.dateTime = dateTime;
        this.address = address;
    }

    protected string Title => title;
    protected DateTime DateTime => dateTime;

    public string StandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {dateTime.ToString("MMMM dd, yyyy")}\nTime: {dateTime.ToString("hh:mm tt")}\nAddress: {address}";
    }

    public abstract string FullDetails();
    public abstract string ShortDescription();
}
