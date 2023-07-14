public class Cycling: Activity
{
    private double _speed;
    public Cycling(string date, int lenghtInMinutes, double speed):base(date, lenghtInMinutes)
    {
        _speed=speed;
        SetActivityType("Cycling");
    }

    public override double CalculateDistance()
    {
        double distance=(_speed*GetLenghtInMinutes())/60;
        return distance ;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        double pace= 60/_speed;
        return pace;
    }
}