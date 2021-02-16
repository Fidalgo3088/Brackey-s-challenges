using System;

namespace Challenge_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Roll the dice";
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.Green;

            int roll1 = 0;
            int roll2 = 0;
            int attempts = 0;

            // Random getal generator + genereer random getal tussen 1 en 10
            Random rnd = new Random();
            roll1 = rnd.Next(1, 10);
            roll2 = rnd.Next(1, 10);

            Console.WriteLine("Press enter to roll the dice.");
            Console.WriteLine(Environment.NewLine);

            while ( roll1 != roll2)
            {
                Console.ReadKey();
                roll1 = rnd.Next(1, 10);
                roll2 = rnd.Next(1, 10);
                attempts++;
                Console.WriteLine($"Attempt nr: {attempts}");
                Console.WriteLine($"Roll 1: {roll1}");
                Console.WriteLine($"Roll 2: {roll2}");
                Console.WriteLine();                
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"It took you {attempts} attempts to roll two of a kind.");
            Console.ReadKey();        
        }
    }
}
