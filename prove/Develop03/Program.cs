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
//Creativity: I created a list of scriptures and reference on the Scripture() constructor. 
//The constructor will select a random scripture from the list and the program will display the random scripture.