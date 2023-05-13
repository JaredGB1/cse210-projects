public class JournalEntry
{
    
    public string _userEntry="";
    public string _currentDateTime = "";
    
    public string _prompt="";

    public void DisplayEntry()
    {
        DateTime currentDateTime = DateTime.Now;
        _currentDateTime=currentDateTime.ToShortDateString();
        Console.WriteLine($"Date: {_currentDateTime} - Prompt: {_prompt} \n{_userEntry}");
    }

}