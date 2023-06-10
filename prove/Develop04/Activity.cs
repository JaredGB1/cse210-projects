public class Activity
{
    private string _activityName;
    private string _description;
    private int _durationInSeconds;
    private List<Activity> _activityList=new List<Activity>();
    public Activity()
    {
        _activityName="";
        _description="";
    }
    public void SetActivityName(string activityName)
    {
        _activityName=activityName;
    }
     public void SetDescription(string description)
    {
        _description=description;
    }
    public void SetDurationInSeconds(int durationInSeconds)
    {
        _durationInSeconds=durationInSeconds;
    }
    public int GetDurationInSeconds()
    {
        return _durationInSeconds;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _durationInSeconds = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        PausingWhileShowingASpinner(6);
        Console.WriteLine($"You hace completed another {_durationInSeconds} seconds of the {_activityName} Activity");
    }
    public void PausingWhileShowingASpinner(int duration)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        int i = 0;
        while (DateTime.Now < futureTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
    }

    public void AddActivityList(Activity activity)
    {
        _activityList.Add(activity);
    }
    public void SaveLogFile(BreathingActivity breathingActivity, ReflectingActivity reflectingActivity, ListingActivity listingActivity)
    {
        
        using (StreamWriter outputFile = new StreamWriter("log.csv"))
        {
            outputFile.WriteLine("Activity Name, Total number of seconds, Total number of Times");
            outputFile.WriteLine($"{breathingActivity.GetActivityName()}, {breathingActivity.GetTotalNumberOfSeconds()}, {breathingActivity.GetTotalNumberOfTimes()}");
            outputFile.WriteLine($"{reflectingActivity.GetActivityName()}, {reflectingActivity.GetTotalNumberOfSeconds()}, {reflectingActivity.GetTotalNumberOfTimes()}");
            outputFile.WriteLine($"{listingActivity.GetActivityName()}, {listingActivity.GetTotalNumberOfSeconds()}, {listingActivity.GetTotalNumberOfTimes()}");
            outputFile.WriteLine();
            outputFile.WriteLine("Activity Log");
            outputFile.WriteLine("Activity, Duration in Seconds");
            foreach(Activity activity1 in breathingActivity._activityList)
            {
                outputFile.WriteLine($"{activity1._activityName},{activity1._durationInSeconds}");
            }
            foreach(Activity activity1 in reflectingActivity._activityList)
            {
                outputFile.WriteLine($"{activity1._activityName},{activity1._durationInSeconds}");
            }
            foreach(Activity activity1 in listingActivity._activityList)
            {
                outputFile.WriteLine($"{activity1._activityName},{activity1._durationInSeconds}");
            }
        }
        Console.WriteLine($"A log of the activities has been saved as log.csv");
    }


    
}