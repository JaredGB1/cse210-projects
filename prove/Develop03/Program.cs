using System;

class Program
{
    static void Main(string[] args)
    {   //Code if the user wants to provide the reference and the scripture text
        //Reference reference = new Reference("Proverbs", 3, 5, 6);
        //string scriptureText1="Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        //Scripture scripture=new Scripture(reference.GetReference(),scriptureText1);

        //Code to get a random scripture.
        //Creating a new Scripture variable.
        Scripture scripture = new Scripture();
        string status = "";
        //While loop used to quit the program if the user types "quit".
        while (status != "quit")
        {
            Console.Clear();
            //Calling the GetRenderedText() method to show the updated list of words in the console.
            scripture.GetRenderedText();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            status = Console.ReadLine();
            //Calling the HideWords() method to hide a random amount of words from the list of words.
            scripture.HideWords();
            //Calling the IsCompletelyHidden() method to check if the list of words is completely hidden to end the program.
            scripture.IsCompletelyHidden();
        }
    }
}
//Creativity: I created a list of scriptures and references on the Scripture() constructor. 
//The constructor will select a random scripture from the list and the program will display the random scripture.