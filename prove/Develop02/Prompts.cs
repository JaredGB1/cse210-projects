public class Prompts
{   
    public Random random=new Random();
    public List<string> _prompts=new List<string>{"What was your favorite part of the day?" , "What was the most interesting part of your day?" , "What was your favorite phrase of the day?","Did you learn something new today?", "Do you met someone new today?"};

    public string RandomPrompt()
    {   
        int randomIndex=random.Next(_prompts.Count);
        string randomPrompt=_prompts[randomIndex];
        return randomPrompt;
    }
}