using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new List<int>();
        int number=-1;
        double total=0;
        double average=0;
        int largestNumber=0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(number!=0)
        {
            Console.WriteLine("Enter number: ");
            number=int.Parse(Console.ReadLine());
            if(number!=0)
            {
                numbers.Add(number);
            }
            
        }
        foreach(int n in numbers)
        {
            total+=n;
            if(largestNumber<n)
            {
                largestNumber=n;
            }
        }
        average=total/numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}