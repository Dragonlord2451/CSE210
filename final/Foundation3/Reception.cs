using System;

public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail)
        : base(title, description, dateTime, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return StandardDetails() + $"\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string ShortDescription()
    {
        return $"Type: Reception\nTitle: {Title}\nDate: {DateTime.ToString("MMMM dd, yyyy")}";
    }
}
