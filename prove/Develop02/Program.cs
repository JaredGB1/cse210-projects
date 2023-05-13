using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DateTime currentDateTime = DateTime.Now;
        Journal journal= new Journal();
        Prompts prompt=new Prompts();
        string menuNumber="";
        Console.WriteLine("Welcome to this Journal Program :)");
        Console.WriteLine("Please select one of the following choices: ");
        while(menuNumber!="5")
        {
            journal.DisplayMenu();
            menuNumber=Console.ReadLine();
            if(menuNumber=="1")
            {
                JournalEntry entry= new JournalEntry();
                entry._currentDateTime=currentDateTime.ToShortDateString();
                entry._prompt= prompt.RandomPrompt();
                Console.WriteLine($"{entry._prompt}");
                entry._userEntry=Console.ReadLine();
                journal._entryList.Add(entry);                   
            }
            else if(menuNumber=="2")
            {
                journal.DisplayEntries();
            }
            else if(menuNumber=="3")
            {
                Console.WriteLine("What is the filename?");
                journal._fileName=Console.ReadLine();
                journal._entryList=journal.LoadJournal();
            }
            else if (menuNumber=="4")
            {
                Console.WriteLine("What is the filename?");
                journal._fileName=Console.ReadLine();
                journal.SaveJournal();
            }
            else if(menuNumber=="5")
            {
                Console.WriteLine("Goodbye! We hope to see you tomorrow");
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 to 5");
            }
        }
        Environment.Exit(0);
    }

   
}