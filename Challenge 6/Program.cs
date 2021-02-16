using System;

namespace Challenge_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Word calculator";
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine($"Enter a sentence: ");
            string sentence1 = Console.ReadLine();       
            Console.WriteLine();
            Console.WriteLine($"Enter another sentence: ");
            string sentence2 = Console.ReadLine();            
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"There are {TotalWords(sentence1)} words in the first sentence.");
            Console.WriteLine();
            Console.WriteLine($"There are {TotalWords(sentence2)} words in the second sentence.");
            Console.ReadKey();

        }
        static int TotalWords (string sentence)
        {
                int total = sentence.Split(' ').Length;              
                return total;            
        }

    }
}
