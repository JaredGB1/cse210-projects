using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1= new Address("349 Emerson Road","Calhoun","Louisiana","United States");
        Customer customer1= new Customer("Olivia Taylor", address1);
        Order order1=new Order(customer1);
        order1.AddAProduct("Long Sword",1,10,2);
        order1.AddAProduct("Amplifying Tome",2,20,1);
        order1.AddAProduct("Ruby Crystal",3,15,2);
        Console.WriteLine("----Order 1 Details----");
        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine(order1.DisplayPackingLabel());
        order1.DisplayTotalPrice();
        

        Address address2= new Address("29 calle 30-43","Zona 25","Guatemala", "Guatemala");
        Customer customer2=new Customer("Jared Gonzalez",address2);
        Order order2=new Order(customer2);
        order2.AddAProduct("Sapphire Crystal",4,10,2);
        order2.AddAProduct("Faerie Charm",5,5,1);
        order2.AddAProduct("Cloak of Agility",6,12.5,2);
        Console.WriteLine();
        Console.WriteLine("----Order 2 Details----");
        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine(order2.DisplayPackingLabel());
        order2.DisplayTotalPrice();
    }
}