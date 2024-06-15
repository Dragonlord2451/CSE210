using System;

class ListingActivity : Activity
{
    private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random random = new Random();

    public ListingActivity()
    {
        name = "Listing";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void PerformActivity()
    {
        Console.WriteLine(prompts[random.Next(prompts.Length)]);
        ShowSpinner(5);

        Console.WriteLine("Start listing items...");
        int count = 0;
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.ReadLine();
            count++;
            elapsed += 5;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}
