public class Swimming: Activity
{
    private double _laps;
    public Swimming(string date, int lenghtInMinutes, double laps):base(date, lenghtInMinutes)
    {
        _laps=laps;
        SetActivityType("Swimming");
    }

    public override double CalculateDistance()
    {
        double distance=(_laps*50)/1000;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed= (CalculateDistance()/GetLenghtInMinutes())*60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace= GetLenghtInMinutes()/CalculateDistance();
        return pace;
    }
}