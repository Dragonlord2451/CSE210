using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            elapsed += 4;
            if (elapsed >= duration) break;
            
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
            elapsed += 4;
        }
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
