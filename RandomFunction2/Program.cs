using System;

namespace RandomFunction2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;

            while (i <= 40)
            {
                int dice = GetRandomNumber(1, 7);
                Console.WriteLine(dice);
                i++;
            }
            
             Console.WriteLine("Thank you for choosing the random number selecter!");
            

            Console.ReadLine();
        }

        public static int GetRandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}
