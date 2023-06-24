public class CheckListGoals:Goals
{
    private int _amountOfPoints;
    private int _bonusPoints;
    private Boolean _completed;
    private int _numberOfTimesCompleted;
    private int _totalNumberOfTimes;

    public CheckListGoals(string name, string description, int amountOfPoints, int bonusPoints, int totalNumberOfTimes, int numberOfTimesCompleted, Boolean completed)
    {
        SetGoalName(name);
        SetGoalDescription(description);
        SetGoalType("CheckList");
        _numberOfTimesCompleted=numberOfTimesCompleted;
        _amountOfPoints=amountOfPoints;
        _totalNumberOfTimes=totalNumberOfTimes;
        _bonusPoints=bonusPoints;
        _completed=completed;
        
    }
    public int GetAmountOfPoints()
    {
        return _amountOfPoints;
    }
    public override string DisplayGoal()
    {
        string goalString;
        if (IsCompleted()==true)
        {
            goalString=$"[X] {GetGoalName()} ({GetGoalDescription()}) -- Completed {_numberOfTimesCompleted}/{_totalNumberOfTimes}";
        }
        else
        {
            goalString=$"[] {GetGoalName()} ({GetGoalDescription()}) -- Completed {_numberOfTimesCompleted}/{_totalNumberOfTimes}";
        }
        return goalString;
    }
     public override string GetGoalInformation()
    {
        string GoalInformation=$"CheckListGoals;{GetGoalName()}~{GetGoalDescription()}~{_amountOfPoints}~{_bonusPoints}~{_totalNumberOfTimes}~{_numberOfTimesCompleted}~{_completed}";
        return GoalInformation;
    }
    public override int RecordEvent()
    {   
        int totalPoints=0;
        _numberOfTimesCompleted=_numberOfTimesCompleted+1;
        if(IsCompleted()==true)
        {
            Console.WriteLine($"Congratulations! You have been awarded {_amountOfPoints} points. \nYou recieved an aditional {_bonusPoints} bonus points for completing the goal!");
            totalPoints=_amountOfPoints+_bonusPoints;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have been awarded {_amountOfPoints} points.");
            totalPoints=_amountOfPoints;
        }
        return totalPoints;
    }
    public override bool IsCompleted()
    {
        if(_numberOfTimesCompleted==_totalNumberOfTimes)
        {
            _completed=true;
        }
        else
        {
            _completed=false;
        }
        return _completed;
    }
}