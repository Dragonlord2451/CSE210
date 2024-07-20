using System;

public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast)
        : base(title, description, dateTime, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string FullDetails()
    {
        return StandardDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }

    public override string ShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {DateTime.ToString("MMMM dd, yyyy")}";
    }
}
