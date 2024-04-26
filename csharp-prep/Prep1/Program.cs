using System;

class Program
{
    public static void Main()
    {
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine(); // Read first name

        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine(); // Read last name

        Console.WriteLine($"Your name is {lastName}, {firstName}, {lastName}."); // Display formatted message
    }
}
