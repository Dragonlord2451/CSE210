using System;
using System.Threading;

abstract class Activity
{
    protected int duration;
    protected string name;
    protected string description;

    public void Start()
    {
        ShowStartingMessage();
        SetDuration();
        PrepareToBegin();
        PerformActivity();
        ShowEndingMessage();
    }

    private void ShowStartingMessage()
    {
        Console.WriteLine($"Starting {name} Activity");
        Console.WriteLine(description);
    }

    private void SetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    private void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);
    }

    private void ShowEndingMessage()
    {
        Console.WriteLine("Good job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {name} activity for {duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract void PerformActivity();
}
