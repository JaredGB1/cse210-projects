using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator= new Random();
        int magicNumber= randomGenerator.Next(1,100);
        int numberOfGuesses=0;
        int guess=0;
        while (magicNumber != guess)
        {
            Console.WriteLine("What is your guess? ");
            guess=int.Parse(Console.ReadLine());
            if(guess>magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if(guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            numberOfGuesses+=1;    

        }
        Console.WriteLine($"You guessed it!. Number of guesses: {numberOfGuesses}");
        Console.WriteLine($"The Magic number was {magicNumber}");
        
    }
}