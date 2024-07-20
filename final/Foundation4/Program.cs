using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 11, 3), 30, 4.8), // Distance in km
            new Cycling(new DateTime(2024, 11, 3), 45, 20), // Speed in kph
            new Swimming(new DateTime(2024, 11, 3), 60, 30) // Laps
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
