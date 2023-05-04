public class JournalEntry
{
    
    public string _userEntry="";
    public DateTime _currentDateTime = DateTime.Now;
    
    public string _prompt="";

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_currentDateTime.ToShortDateString()} - Prompt: {_prompt} \n{_userEntry}");
    }

}