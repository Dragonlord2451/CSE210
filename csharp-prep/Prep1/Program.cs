using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine(); // Read first name

        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine(); // Read last name

        Console.WriteLine($"Your name is {lastName}, {firstName}, {lastName}."); // Display formatted message
    }
}
