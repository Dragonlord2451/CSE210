using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Please enter your grade percentage: "); 
        string input = Console.ReadLine(); 
        double percentage;

        
        if (double.TryParse(input, out percentage))
        {
            string letter; 

            
            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            
            Console.WriteLine($"Your letter grade is: {letter}");

        
            if (percentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("You didn't pass the course. Keep trying and you'll improve!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid grade percentage.");
        }
    }
}

        
