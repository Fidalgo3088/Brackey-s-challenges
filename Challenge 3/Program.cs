using System;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Math solver";
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.Green;

            int answer1;
            int answer2;
            int answer3;
            int totalRightanswers = 0;

            //int newNumber;
            //// Random getal generator + genereer random getal tussen 1 en 10
            //Random rnd = new Random();
            //newNumber = rnd.Next(1, 1);

            Console.Write("15 + 2 * 2 = ");
            answer1 = Convert.ToInt32(Console.ReadLine());
            if (answer1 == 34)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.Write("10 * 2 / 4 = ");
            answer2 = Convert.ToInt32(Console.ReadLine());
            if (answer2 == 5)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.Write("(4 + 3 + 2 + 1) / 2 = ");           
            answer3 = Convert.ToInt32(Console.ReadLine());
            if (answer3 == 5)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            if (answer1 == 34 ) 
            {
                totalRightanswers++;
            }
            if (answer2 == 5)
            {
                totalRightanswers++;
            }
            if (answer3 == 5)
            {
                totalRightanswers++;
            }

            if (totalRightanswers == 3)
            {
                Console.WriteLine($"You solved the {totalRightanswers} problems correctly! =)");
            }
            else if (totalRightanswers == 2) 
            {
                Console.WriteLine($"You solved {totalRightanswers} problems correctly!");
            }
            else if (totalRightanswers == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You solved only {totalRightanswers} problem correctly! =(");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You're a dumbass");
            }
            Console.ReadKey();

        }
    }
}
