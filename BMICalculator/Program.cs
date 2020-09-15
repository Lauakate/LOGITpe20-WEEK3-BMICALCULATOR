using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int Age = Int32.Parse(Console.ReadLine());
            if (Age <= 20)
            {
                Console.WriteLine("You are too young");
            }
            else if (Age >= 60)
            {
                Console.WriteLine("You are too old");
            }
            else
            {
                double Height;
                Console.WriteLine("How tall are you?");
                Height = Double.Parse(Console.ReadLine());
                Console.WriteLine($"You are {Height} meters tall.");
                Console.WriteLine("What is your weight?");
                double Weight = Int32.Parse(Console.ReadLine());
                double Result = Weight / (Height * Height);
                Console.WriteLine($"Your body mass is {Result}.");

                if (Result <= 19)
                {
                    Console.WriteLine("You are underweight.");
                }
                else if (Result <= 25)
                {
                    Console.WriteLine("Your weight is healthy");
                }
                else if (Result >= 25 && Result <= 30)
                {
                    Console.WriteLine("You are overweight.");
                }
                else if (Result >= 30)
                {
                    Console.WriteLine("You are obese.");
                }
            }
           
        }
    }
}
