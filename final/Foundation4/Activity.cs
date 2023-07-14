public class Activity
{
    private string _date;
    private int _lenghtInMinutes;
    private string _activityType;
    public Activity(string date, int lenghtInMinutes)
    {
        _date=date;
        _lenghtInMinutes=lenghtInMinutes;
        _activityType="";
    }
    public void SetActivityType(string activityType)
    {
        _activityType=activityType;
    }
    public int GetLenghtInMinutes()
    {
        return _lenghtInMinutes;
    }
    public void GetSummary()
    {
        Console.WriteLine($"Summary: \n{_date} {_activityType} ({_lenghtInMinutes} min)- Distance {CalculateDistance()} km, Speed {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km");
    }
    public virtual double CalculateDistance()
    {
        double temporal=0;
        return temporal;
    }
    public virtual double CalculateSpeed()
    {
        double temporal=0;
        return temporal;
    }
    public virtual double CalculatePace()
    {
        double temporal=0;
        return temporal;
    }
}