public class Goals
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _baseAmountOfPoints;
    private List<Goals> _goalsList = new List<Goals>();

    public Goals()
    {
        _goalName = "";
        _goalDescription = "";
        _baseAmountOfPoints = 0;
    }
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public string GetGoalType()
    {
        return _goalType;
    }
    public void SetBaseAmountOfPoints(int amountOfPoints)
    {
        _baseAmountOfPoints = _baseAmountOfPoints + amountOfPoints;
    }
    public int GetBaseAmountOfPoints()
    {
        return _baseAmountOfPoints;
    }
    public void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. CheckList Goal");
        Console.WriteLine("What type of goal would you like to create? ");
        int typeOfGoal = int.Parse(Console.ReadLine());
        if (typeOfGoal == 1)
        {
            Console.WriteLine("What is the name of your Goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your Goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with your goal?");
            int amountOfPoints = int.Parse(Console.ReadLine());
            Boolean completed = false;
            SimpleGoals simpleGoal = new SimpleGoals(name, description, amountOfPoints, completed);
            _goalsList.Add(simpleGoal);
        }
        else if (typeOfGoal == 2)
        {

            Console.WriteLine("What is the name of your Goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your Goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with your goal?");
            int amountOfPoints = int.Parse(Console.ReadLine());
            EternalGoals eternalGoal = new EternalGoals(name, description, amountOfPoints);
            _goalsList.Add(eternalGoal);
        }
        else if (typeOfGoal == 3)
        {

            Console.WriteLine("What is the name of your Goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your Goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with your goal?");
            int amountOfPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times does this list needs to be acomplished for a bonus?");
            int totalNumberOfTimes = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for acomplishing it that many times?");
            int bonusPoints = int.Parse(Console.ReadLine());
            Boolean completed = false;
            int numberOfTimesCompleted = 0;
            CheckListGoals checkListGoal = new CheckListGoals(name, description, amountOfPoints, totalNumberOfTimes, bonusPoints, numberOfTimesCompleted, completed);
            _goalsList.Add(checkListGoal);
        }
    }

    public void ListGoals()
    {
        int i = 1;
        foreach (Goals goal in _goalsList)
        {
            Console.WriteLine($"{i}. {goal.DisplayGoal()}");
            i++;
        }
    }
    public virtual string DisplayGoal()
    {
        return "";
    }
    public virtual int RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        int i = 1;
        foreach (Goals goal in _goalsList)
        {
            Console.WriteLine($"{i}. {goal.GetGoalName()}");
            i++;
        }
        Console.WriteLine("Which goal did you accomplish?");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        SetBaseAmountOfPoints(_goalsList[goalIndex].RecordEvent());
        return _baseAmountOfPoints;
    }
    public virtual bool IsCompleted()
    {
        return false;
    }

    public virtual string GetGoalInformation()
    {
        return "";
    }
    public void SaveGoalsFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(GetBaseAmountOfPoints());
            foreach (Goals goal in _goalsList)
            {
                outputFile.WriteLine(goal.GetGoalInformation());
            }
        }
        Console.WriteLine($"File saved as {fileName}");
    }

    public void LoadGoalsFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int i = 0;
        foreach (string line in lines)
        {
            if (i == 0)
            {
                SetBaseAmountOfPoints(int.Parse(line));
            }
            else
            {
                Boolean completed;
                string[] parts = line.Split(":");
                string goalType = parts[0];
                string[] goalInformation = parts[1].Split("~");
                if (goalType == "SimpleGoals")
                {
                    if (goalInformation[3] == "True")
                    {
                        completed = true;
                    }
                    else
                    {
                        completed = false;
                    }
                    SimpleGoals simpleGoal = new SimpleGoals(goalInformation[0], goalInformation[1], int.Parse(goalInformation[2]), completed);
                    _goalsList.Add(simpleGoal);
                }
                else if (goalType == "EternalGoals")
                {
                    EternalGoals eternalGoal = new EternalGoals(goalInformation[0], goalInformation[1], int.Parse(goalInformation[2]));
                }
                else if (goalType == "CheckListGoals")
                {
                    if (goalInformation[6] == "True")
                    {
                        completed = true;
                    }
                    else
                    {
                        completed = false;
                    }
                    CheckListGoals checkListGoals = new CheckListGoals(goalInformation[0], goalInformation[1], int.Parse(goalInformation[2]), int.Parse(goalInformation[3]), int.Parse(goalInformation[4]), int.Parse(goalInformation[5]), completed);
                    _goalsList.Add(checkListGoals);
                }
            }
            i++;
        }
        Console.WriteLine($"File {fileName} loaded");
    }
}
