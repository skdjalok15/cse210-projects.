using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("456 Oak Ave", "Provo", "UT", "USA");
        Address address3 = new Address("789 Elm Blvd", "Rexburg", "ID", "USA");

        Event lecture = new Lecture(
            "Tech Talk",
            "Exploring the future of AI",
            "2025-01-15",
            "10:00 AM",
            address1,
            "Dr. John Smith",
            100
        );

        Event reception = new Reception(
            "Networking Night",
            "Meet professionals in your field",
            "2025-02-20",
            "6:00 PM",
            address2,
            "rsvp@events.com"
        );

        Event outdoorGathering = new OutdoorGathering(
            "Community Picnic",
            "A fun day for everyone",
            "2025-03-25",
            "11:00 AM",
            address3,
            "Sunny"
        );

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (Event evt in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("\n----------------------\n");
        }
    }
}
