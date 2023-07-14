public class Running: Activity
{
    private double _distance;
    public Running(string date, int lenghtInMinutes, double distance):base(date, lenghtInMinutes)
    {
        _distance=distance;
        SetActivityType("Running");
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        double speed= (_distance/GetLenghtInMinutes())*60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace= GetLenghtInMinutes()/_distance;
        return pace;
    }
}