public class ListingActivity:Activity
{
    private List<string> _promptsList=new List<string>();
    private int _totalNumberOfTimes=0;
    private int _totalNumberOfSeconds=0;
    public ListingActivity()
    {
        SetActivityName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _promptsList.Add("Who are people that you appreciate?");
        _promptsList.Add("What are personal strengths of yours?");
        _promptsList.Add("Who are people that you have helped this week?");
        _promptsList.Add("When have you felt the Holy Ghost this month?");
        _promptsList.Add("Who are some of your personal heroes?");
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
        Random random=new Random();
        int randomIndex= random.Next(0,4);
        string randomPrompt= _promptsList[randomIndex];
        int numberOfItems=0;
        int durationInSeconds=GetDurationInSeconds();
        Activity activity= new Activity();
        activity.SetActivityName("Listing");
        activity.SetDurationInSeconds(durationInSeconds);
        Console.WriteLine("Get Ready...");
        PausingWhileShowingASpinner(5);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {randomPrompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        for(int i = 5; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durationInSeconds);
        Console.WriteLine();
        while(DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            numberOfItems++;
        }
        Console.WriteLine($"You listed {numberOfItems} items!");
        Console.WriteLine();
        DisplayEndingMessage();
        PausingWhileShowingASpinner(6);
        AddActivityList(activity);
        _totalNumberOfSeconds=_totalNumberOfSeconds+durationInSeconds;
        _totalNumberOfTimes=_totalNumberOfTimes+1;
    }

}