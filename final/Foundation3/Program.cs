using System;

public class Program
{
    public static void Main()
    {
        Address myAddress1 = new Address("100 S W Temple St", "Salt Lake City", "UT", "84101");
        Address myAddress2 = new Address("789 Elm St", "Othertown", "TX", "23456");
        Address myAddress3 = new Address("Aba owerri Road", "Aba", "Abia", "84101");

        Lecture mylecture = new Lecture(
            "Inheritance in C#",
            "Learn practical aspect of Inheritance in C#.",
            new DateTime(2023, 4, 30, 13, 0, 0),
            myAddress1,
            "Professor Nathan Parrish",
            50
        );

        Console.WriteLine("Lecture:");
        mylecture.GetFullDetails();

        Reception myReception = new Reception(
            "Networking Mixer",
            "Join us for an evening of networking and drinks.",
            new DateTime(2023, 4, 28, 15, 3, 0),
            myAddress2,
            "rsvp@company.com"
        );

        Console.WriteLine("Reception:");        
        myReception.GetFullDetails();   

        
        OutDoor myOutDoor = new OutDoor(
        "Nigerian BYUI on line students",
        "Celebration of successful semester.",
        new DateTime(2023, 4, 7, 12, 3, 0),
        myAddress3,
        "sunny"
    );
        Console.WriteLine("Out Door Event:");       
        myOutDoor.GetFullDetails();
        
    }
}