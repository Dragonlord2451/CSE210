using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    public static void Main()
    {
        LoadGoals();
        while (true)
        {
            DisplayGoals();
            DisplayScore();
            DisplayMenu();
        }
    }

    private static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayProgress());
        }
    }

    private static void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Create Simple Goal");
        Console.WriteLine("2. Create Eternal Goals");
        Console.WriteLine("3. Create list Goals");
        Console.WriteLine("4. Record for points :)");
        Console.WriteLine("5.Exit");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            case "4":
                RecordEvent();
                break;
            case "5":
                SaveGoals();
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private static void CreateSimpleGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        goals.Add(new SimpleGoal(name, points));
    }

    private static void CreateEternalGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for each completion: ");
        int points = int.Parse(Console.ReadLine());

        goals.Add(new EternalGoal(name, points));
    }

    private static void CreateChecklistGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for each completion: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of times required: ");
        int requiredTimes = int.Parse(Console.ReadLine());
        Console.Write("Enter the bonus points for completing all: ");
        int bonusPoints = int.Parse(Console.ReadLine());

        goals.Add(new ChecklistGoal(name, points, requiredTimes, bonusPoints));
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.RecordEvent();
            score += goal.Points;

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
            {
                score += checklistGoal.GetBonusPoints();
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    private static void LoadGoals()
    {
        // Implement loading logic (e.g., from a file)
    }

    private static void SaveGoals()
    {
        // Implement saving logic (e.g., to a file)
    }
}
