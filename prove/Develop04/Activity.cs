public class Activity
{
    private string _activityName;
    private string _description;
    private int _durationInSeconds;
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
    public int GetDurationInSeconds()
    {
        return _durationInSeconds;
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
}