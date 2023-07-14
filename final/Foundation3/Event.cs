public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _eventType;
    Address _address;

    public Event(string title, string description, string time, string date, Address address)
    {
        _title=title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
    }

    public void SetEventType(string eventType)
    {
        _eventType=eventType;
    }

    public string GetEventType()
    {
        return _eventType;
    }
    public void DisplayStandarDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.ReturnAddressString()}");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"Event type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Address: {_address.ReturnAddressString()}");
    }
}