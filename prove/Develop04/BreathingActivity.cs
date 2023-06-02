public class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        SetActivityName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunActivity()
    {
        Console.WriteLine("Get Ready...");
        PausingWhileShowingASpinner(5);
        int durationInSeconds=GetDurationInSeconds();
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
    }
}