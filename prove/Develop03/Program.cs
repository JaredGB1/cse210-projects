using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureReference = reference.GetReference();
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(scriptureText, scriptureReference);
        string status = "";
        while (status != "quit")
        {
            scripture.getRenderedText();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            status = Console.ReadLine();
            scripture.HideWords();
            Console.Clear();
            scripture.IsCompletelyHidden();
        }
    }
}