using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        BreathingActivity breathingActivity=new BreathingActivity();
        ReflectingActivity reflectingActivity=new ReflectingActivity();
        ListingActivity listingActivity=new ListingActivity();
        Activity activity= new Activity();
        string menuOption="";
        while(menuOption!="4")
        {
            activity.DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            menuOption=Console.ReadLine();
            if(menuOption=="1")
            {
                breathingActivity.DisplayStartingMessage();
                Console.Clear();
                breathingActivity.RunActivity();
                
            }
            else if (menuOption=="2")
            {
                reflectingActivity.DisplayStartingMessage();
                Console.Clear();
                reflectingActivity.RunActivity();
            }
            else if(menuOption=="3")
            {
                listingActivity.DisplayStartingMessage();
                Console.Clear();
                listingActivity.RunActivity();
            }
            else if(menuOption=="4")
            {
                activity.SaveLogFile(breathingActivity,reflectingActivity,listingActivity);
                Console.WriteLine("Thank you for using the Mindfulness Program");
                Environment.Exit(0);
            }
            Console.Clear();
        }
    }
}
//Creativity:
//For creativity, the program will save a Log CSV file when the user types "4" to quit the program.
//The log file contains the number of times the user did the different activities.
//The log file will also have the total number of seconds spent on the  different activities
//The log file will also show the activities with the number of seconds spent by the user.