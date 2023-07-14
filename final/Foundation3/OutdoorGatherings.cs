public class OutdoorGatherings: Event
{
    private string _weatherForecast;
    public OutdoorGatherings(string title, string description, string time, string date, Address address, string weatherForecast): base(title, description, time, date, address)
    {
        _weatherForecast=weatherForecast;
        SetEventType("Outdoor Gathering");
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {GetEventType()}");
        DisplayStandarDetails();
        Console.WriteLine($"Weather Forecast: {_weatherForecast}");
    }
}