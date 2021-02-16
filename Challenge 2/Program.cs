using System;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Average calculator";
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Input a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input a second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input a third number: ");
            double number3 = Convert.ToDouble(Console.ReadLine());

            double average = (number1 + number2 + number3) / 3;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The average of these number is: {average} ");
            Console.ReadKey();

        }
    }
}
