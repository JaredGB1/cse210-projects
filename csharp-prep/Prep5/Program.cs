using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name=PromptUserName();
        int number=PromptUserNumber();
        int squareNumber=SquareNumber(number);
        DisplayResult(name, squareNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");   
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name=Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number=int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squareNumber=number*number;
        return squareNumber;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}