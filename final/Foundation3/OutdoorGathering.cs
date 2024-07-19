using System;

/// <summary>
/// Represents an outdoor gathering event.
/// It extends the Event class and adds a property for the weather forecast.
/// </summary>

class OutdoorGathering : Event
{
    private string WeatherForecast { get; set; }

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nWeather Forecast: {WeatherForecast}";
    }
}