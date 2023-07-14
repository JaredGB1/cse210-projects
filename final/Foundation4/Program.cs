using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList=new List<Activity>();
        Running running=new Running("14 July 2023",30,4.8);
        activityList.Add(running);
        Cycling cycling= new Cycling("14 July 2023",60,1);
        activityList.Add(cycling);
        Swimming swimming= new Swimming("14 July 2023", 30, 10);
        activityList.Add(swimming);
        foreach(Activity activity in activityList)
        {
            activity.GetSummary();
        }
        

    }
}