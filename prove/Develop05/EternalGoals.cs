public class EternalGoals:Goals
{
    private int _amountOfPoints;
    public EternalGoals(string name, string description, int amountOfPoints)
    {
        SetGoalName(name);
        SetGoalDescription(description);
        SetGoalType("Eternal");
        _amountOfPoints=amountOfPoints;
    }
    public void SetAmountOfPoints(int amountOfPoints)
    {
        _amountOfPoints=amountOfPoints;
    }
    public int GetAmountOfPoints()
    {
        return _amountOfPoints;
    }
    public override string DisplayGoal()
    {
        string goalString=$"[] {GetGoalName()} ({GetGoalDescription()})";
        return goalString;
    }
    public override string GetGoalInformation()
    {
        string GoalInformation=$"EternalGoals:{GetGoalName()}~{GetGoalDescription()}~{_amountOfPoints}";
        return GoalInformation;
    }
     public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have been awarded {_amountOfPoints} points");
        return _amountOfPoints;
    }
}