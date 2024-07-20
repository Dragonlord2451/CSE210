using System;

public class Program
{
    public static void Main()
    {
        Address lectureAddress = new Address("123 Main St", "Anytown", "CA", "12345", "USA");
        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in technology.", new DateTime(2024, 8, 1, 14, 0, 0), lectureAddress, "John Doe", 100);

        Address receptionAddress = new Address("456 Elm St", "Othertown", "NY", "67890", "USA");
        Reception reception = new Reception("Networking Event", "A chance to network with industry professionals.", new DateTime(2024, 8, 2, 18, 0, 0), receptionAddress, "rsvp@example.com");

        Address outdoorAddress = new Address("789 Pine St", "Sometown", "TX", "54321", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun outdoor picnic.", new DateTime(2024, 8, 3, 12, 0, 0), outdoorAddress, "Sunny with a chance of clouds.");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var e in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(e.FullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
        }
    }
}
