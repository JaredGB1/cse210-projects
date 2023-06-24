public class SimpleGoals:Goals
{
    private int _amountOfPoints;
    private Boolean _completed;

    public SimpleGoals(string name, string description, int amountOfPoints, Boolean completed)
    {
        SetGoalName(name);
        SetGoalDescription(description);
        SetGoalType("Simple");
        _amountOfPoints=amountOfPoints;
        _completed=completed;
    }
    public int GetAmountOfPoints()
    {
        return _amountOfPoints;
    }

    public override string DisplayGoal()
    {
        string goalString;
        if (_completed==true)
        {
            goalString=$"[X] {GetGoalName()} ({GetGoalDescription()})";
        }
        else
        {
            goalString=$"[] {GetGoalName()} ({GetGoalDescription()})";
        }
        return goalString;
    }
    public override string GetGoalInformation()
    {
        string GoalInformation=$"SimpleGoals;{GetGoalName()}~{GetGoalDescription()}~{_amountOfPoints}~{_completed}";
        return GoalInformation;
    }
    public override int RecordEvent()
    {
        _completed=true;
        Console.WriteLine($"Congratulations! You have been awarded {_amountOfPoints} points");
        return _amountOfPoints;
    }
    public override bool IsCompleted()
    {
        return _completed;
    }
}