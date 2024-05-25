// Program.cs
using System;



    class Program
    {
        static void Main(string[] args)
        {
            
            Fraction fraction1 = new Fraction();

            Fraction fraction2 = new Fraction(6);

            Fraction fraction3 = new Fraction(6, 7);

            
            Console.WriteLine("Fraction 1: " + fraction1.GetFractionString());

            Console.WriteLine("Fraction 2: " + fraction2.GetFractionString()); 

            Console.WriteLine("Fraction 3: " + fraction3.GetFractionString()); 

            
            fraction1.Numerator = 3;
            fraction1.Denominator = 4;
            Console.WriteLine("Updated Fraction 1: " + fraction1.GetFractionString()); 

            
            Console.WriteLine("Fraction 1 Decimal: " + fraction1.GetDecimalValue());

            Console.WriteLine("Fraction 3 Decimal: " + fraction3.GetDecimalValue());

            
            Fraction fraction4 = new Fraction(1, 3);
            
            Console.WriteLine("Fraction 4: " + fraction4.GetFractionString());

            Console.WriteLine("Fraction 4 Decimal: " + fraction4.GetDecimalValue());
        }
    }

