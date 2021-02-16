using System;
using System.Collections.Generic; // Library needed to work with lists, for this example its acctualy not needed

namespace Challenge5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "How many students";
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.Green;            

            Console.WriteLine($"How many student are in your class? ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string[] movies = new string[i];
            Console.WriteLine($"Please input the name of the students: ");
            for (i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Here they are alphabetically: ");           
            Array.Sort(movies);
            Console.WriteLine();
            for (i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }
            Console.ReadKey();

        }
    }
}
