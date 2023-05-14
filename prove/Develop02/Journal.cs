using System.IO;
using Microsoft.VisualBasic.FileIO;
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
           string newUserEntry= Entry._userEntry.Replace("\"", "\"\""); 
           outputFile.WriteLine($"\"{Entry._currentDateTime}\",\"{Entry._prompt}\",\"{newUserEntry}\"");
        }

        }
        Console.WriteLine($"File saved as {_fileName}");
    }

    public List<JournalEntry> LoadJournal()
    {
        List<JournalEntry> _entryList=new List<JournalEntry>();
        TextFieldParser parser = new TextFieldParser(_fileName);
        parser.HasFieldsEnclosedInQuotes = true;
        parser.SetDelimiters(",");
        string[] fields;
        while (!parser.EndOfData)
        {
            fields = parser.ReadFields();
            if(fields[0] != "Date")
            {
                JournalEntry entry= new JournalEntry();
                entry._currentDateTime=fields[0].ToString();
                entry._prompt=fields[1].ToString();
                entry._userEntry=fields[2].ToString();
                _entryList.Add(entry);
            }
        } 
        parser.Close();
        return _entryList;
    }
}