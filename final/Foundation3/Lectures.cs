public class Lectures: Event
{
    private string _speaker;
    private int _capacity;
    public Lectures(string title, string description, string time, string date, Address address, string speaker, int capacity ): base(title, description, time, date, address)
    {
        _speaker=speaker;
        _capacity=capacity;
        SetEventType("Lecture");
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {GetEventType()}");
        DisplayStandarDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        
    }

}