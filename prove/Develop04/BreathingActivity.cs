public class BreathingActivity: Activity
{
    private int _totalNumberOfTimes=0;
    private int _totalNumberOfSeconds=0;
    public BreathingActivity()
    {
        SetActivityName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public int GetTotalNumberOfSeconds()
    {
        return _totalNumberOfSeconds;
    }
    
    public int GetTotalNumberOfTimes()
    {
        return _totalNumberOfTimes;
    }
    public void RunActivity()
    {
        
        Console.WriteLine("Get Ready...");
        PausingWhileShowingASpinner(5);
        int durationInSeconds=GetDurationInSeconds();
        Activity activity= new Activity();
        activity.SetActivityName("Breathing");
        activity.SetDurationInSeconds(durationInSeconds);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durationInSeconds);
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in... ");
            for(int i=4; i > 0;i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            for(int i=6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
             
        }
        Console.WriteLine();
        DisplayEndingMessage();
        PausingWhileShowingASpinner(6);
        AddActivityList(activity);
        _totalNumberOfSeconds=_totalNumberOfSeconds+durationInSeconds;
        _totalNumberOfTimes=_totalNumberOfTimes+1;
    }
}