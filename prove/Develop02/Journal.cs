using System.IO;
public class Journal
{
     public List<JournalEntry> _entryList= new List<JournalEntry>();
     public string _fileName;
     public void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    public void DisplayEntries()
    {
        Console.WriteLine();
        foreach(JournalEntry Entry in _entryList)
        {
            Entry.DisplayEntry();
        }
    }

    public void SaveJournal()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine("Date,Prompt,Entry");
            foreach(JournalEntry Entry in _entryList)
        {
           outputFile.WriteLine($"{Entry._currentDateTime},{Entry._prompt},{Entry._userEntry}");
        }

        }
        Console.WriteLine($"File saved as {_fileName}");
    }

    public List<JournalEntry> LoadJournal()
    {
        List<JournalEntry> _entryList=new List<JournalEntry>();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if(parts[0] != "Date")
            {
                JournalEntry entry= new JournalEntry();
                entry._currentDateTime=parts[0];
                entry._prompt=parts[1];
                entry._userEntry=parts[2];
                _entryList.Add(entry);
            }
        }   

        return _entryList;
    }
}