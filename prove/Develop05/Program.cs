using System;

class Program
{
    static void Main(string[] args)
    {
        Goals goal = new Goals();
        int pointsForLevelUp;
        int nextLevel;
        string status = "1";
        while (status != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {goal.GetBaseAmountOfPoints()} points");
            pointsForLevelUp= ((goal.GetUserLevel()+1)*500)-goal.GetBaseAmountOfPoints();
            nextLevel= goal.GetUserLevel()+1;
            Console.WriteLine($"You are currently level: {goal.GetUserLevel()}. You need {pointsForLevelUp} points to reach level {nextLevel}");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.WriteLine("Select a Choice from the Menu: ");
            status = Console.ReadLine();
            if (status == "1")
            {
                goal.CreateNewGoal();
            }
            else if (status == "2")
            {
                Console.WriteLine("Your goals are: ");
                goal.ListGoals();
            }
            else if (status == "3")
            {
                Console.WriteLine("What is the filename for the goal file?");
                string fileName = Console.ReadLine();
                goal.SaveGoalsFile(fileName);
            }
            else if (status == "4")
            {
                Console.WriteLine("What is the filename of the goal file?");
                string fileName = Console.ReadLine();
                goal.LoadGoalsFile(fileName);
            }
            else if (status == "5")
            {
                goal.RecordEvent();
            }
            else if (status == "6")
            {
                Environment.Exit(0);
            }
        }
    }
}
//For creativity, I added a level-up option. For every 500 points, the user will level up. The program will show the user how many points they need to level up alongside their points and their current level.