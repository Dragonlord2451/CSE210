using System;
using System.Collections.Generic;

class NumberAnalysis
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1; // Initial value for loop

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Continue reading input until the user enters 0
        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) // Avoid adding 0 to the list
            {
                numbers.Add(input);
            }
        }

        // Calculate the sum of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = sum / (double)numbers.Count;

        // Find the maximum number in the list
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
