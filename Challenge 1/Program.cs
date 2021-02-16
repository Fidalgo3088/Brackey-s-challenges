using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "A proud Knight story";
            Console.WindowHeight = 40;

            Console.WriteLine("A proud knight named...");
            Console.ReadLine();
            Console.WriteLine("...walked into a bar. At the counter he met a...");
            Console.ReadLine();
            Console.WriteLine("...who asked him what he wanted to drink?");
            Console.ReadLine();
            Console.WriteLine("...shouted the knight! The bartender shushed him quickly.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("But he whas too late.... A dragon ate them both.");
            Console.ReadKey();

        }
    }
}
