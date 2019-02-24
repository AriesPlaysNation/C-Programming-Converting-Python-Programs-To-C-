using System;
using RandomFunction;

namespace RandomFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int month = rnd.Next(1, 12); // random number between and including 1 and 13
            int dice = rnd.Next(1, 6); // random number between and including 1 and 7
            int card = rnd.Next(52); // random number between 0 and 52

            Console.WriteLine(month);
            Console.WriteLine(dice);
            Console.WriteLine(card);

            Console.ReadLine();
        }
    }
}
