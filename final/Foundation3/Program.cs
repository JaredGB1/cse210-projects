using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1= new Address("349 Emerson Road","Calhoun","Louisiana","United States");
        Address address2= new Address("29 calle 30-43","Zona 25","Guatemala", "Guatemala");
        Address address3= new Address("16 calle 60-43","Zona 17","Guatemala", "Guatemala");
        Lectures lectureEvent= new Lectures("Tree Communication With Annie Novak", "In this 3-part lecture series, explore the contemporary science and mysteries of how trees communicate, as well as how to listen in.","4:30pm","July 20, 2023", address1,"Annie Novak",100);
        Receptions receptionEvent= new Receptions("Wedding", "Wedding of Luis Diego and Alejandra","6:00 PM","July 20",address2,"If you want to join the party, send in your response by July 17th Name(s): _____ Im definitely showing up ( ) Cant make it and I feel horrible about it ( ) We have got delicacies for you to choose below");
        OutdoorGatherings outdoorGatheringEvent= new OutdoorGatherings("Family Fun Days"," Family fun days are exactly that, FUN! From inflatable games to funfair rides and delicious BBQ food, there is something for all at this inclusive live event.","10:00 AM","July 31st",address3,"25 C, The air quality is generally acceptable for most individuals. However, sensitive groups may experience minor to moderate symptoms from long-term exposure.");
        lectureEvent.DisplayFullDetails();
        Console.WriteLine("-----------------------------------------------------------------");
        lectureEvent.DisplayStandarDetails();
        Console.WriteLine("-----------------------------------------------------------------");
        lectureEvent.DisplayShortDescription();
        Console.WriteLine("-----------------------------------------------------------------");
        receptionEvent.DisplayFullDetails();
        Console.WriteLine("-----------------------------------------------------------------");
        receptionEvent.DisplayStandarDetails();
        Console.WriteLine("-----------------------------------------------------------------");
        receptionEvent.DisplayShortDescription();
        Console.WriteLine("-----------------------------------------------------------------");
        outdoorGatheringEvent.DisplayFullDetails();
        Console.WriteLine("-----------------------------------------------------------------");
        outdoorGatheringEvent.DisplayStandarDetails();
        Console.WriteLine("-----------------------------------------------------------------");
        outdoorGatheringEvent.DisplayShortDescription();
    }
}