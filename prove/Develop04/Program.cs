using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> activityLog = new Dictionary<string, int>
    {
        { "Breathing", 0 },
        { "Reflection", 0 },
        { "Listing", 0 }
    };

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Show Activity Log and Exit");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    new BreathingActivity().Start();
                    activityLog["Breathing"]++;
                    break;
                case "2":
                    new ReflectionActivity().Start();
                    activityLog["Reflection"]++;
                    break;
                case "3":
                    new ListingActivity().Start();
                    activityLog["Listing"]++;
                    break;
                case "4":
                    ShowActivityLog();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }

    static void ShowActivityLog()
    {
        Console.WriteLine("\nActivity Log:");
        foreach (var entry in activityLog)
        {
            Console.WriteLine($"{entry.Key} Activity: {entry.Value} times");
        }
    }
}


