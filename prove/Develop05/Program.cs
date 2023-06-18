using System;

class Program
{
    static void Main(string[] args)
    {
        Goals goal= new Goals();
        string status="1";
        while(status!="6")
        {
            Console.WriteLine($"You have {goal.GetBaseAmountOfPoints()} points");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.WriteLine("Select a Choice from the Menu: ");
            status=Console.ReadLine();
            if(status=="1")
            {
                goal.CreateNewGoal();
            }
            else if(status=="2")
            {
                goal.ListGoals();
            }
            else if(status=="3")
            {
                Console.WriteLine("What is the filename for the goal file?");
                string fileName=Console.ReadLine();
                goal.SaveGoalsFile(fileName);
            }
            else if(status=="4")
            {
                Console.WriteLine("What is the filename of the goal file?");
                string fileName=Console.ReadLine();
                goal.LoadGoalsFile(fileName);
            }
            else if(status=="5")
            {
                goal.RecordEvent();
            }
            else if(status=="6")
            {
                Environment.Exit(0);
            }
        }
    }
}