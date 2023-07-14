public class Receptions: Event
{
    private string _rsvpEmail;
    public Receptions(string title, string description, string time, string date, Address address, string rsvpEmail): base(title, description, time, date, address)
    {
        _rsvpEmail=rsvpEmail;
        SetEventType("Reception");
    }
    public void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {GetEventType()}");
        DisplayStandarDetails();
        Console.WriteLine($"RSVP Email: {_rsvpEmail}");
    }
}