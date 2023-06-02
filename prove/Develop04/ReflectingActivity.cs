public class ReflectingActivity:Activity
{
    private List<string> _promptsList=new List<string>();
    private List<string> _questionsList=new List<string>();
    public ReflectingActivity()
    {
        SetActivityName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _promptsList.Add("Think of a time when you stood up for someone else.");
        _promptsList.Add("Think of a time when you did something really difficult.");
        _promptsList.Add("Think of a time when you helped someone in need.");
        _promptsList.Add("Think of a time when you did something truly selfless.");
        _questionsList.Add("Why was this experience meaningful to you?");
        _questionsList.Add("Have you ever done anything like this before?");
        _questionsList.Add("How did you feel when it was complete?");
        _questionsList.Add("What made this time different than other times when you were not as successful?");
        _questionsList.Add("What is your favorite thing about this experience?");
        _questionsList.Add("What could you learn from this experience that applies to other situations?");
        _questionsList.Add("What did you learn about yourself through this experience?");
        _questionsList.Add("How can you keep this experience in mind in the future?");
        _questionsList.Add("How did you get started?");
    }
    public void RunActivity()
    {
        Random random= new Random();
        int randomPromptIndex=random.Next(0,3);
        int durationInSeconds=GetDurationInSeconds();
        Console.WriteLine("Get Ready...");
        PausingWhileShowingASpinner(5);
        Console.WriteLine("Consider the following prompt: ");
        string prompt=_promptsList[randomPromptIndex];
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
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
        Console.Clear();
        while(DateTime.Now < futureTime)
        {
            int randomQuestionIndex=random.Next(0,8);
            string randomQuestion= _questionsList[randomQuestionIndex];
            Console.Write($"{randomQuestion}");
            PausingWhileShowingASpinner(10);
            Console.WriteLine();
        }
        Console.WriteLine();
        DisplayEndingMessage();
        PausingWhileShowingASpinner(6);

    }
}