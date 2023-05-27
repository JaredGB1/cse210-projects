using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string status = "";
        while (status != "quit")
        {
            Console.Clear();
            scripture.getRenderedText();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            status = Console.ReadLine();
            scripture.HideWords();
            scripture.IsCompletelyHidden();
        }
    }
}