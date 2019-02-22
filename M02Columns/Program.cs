using System;

namespace M02Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 127.488f;
            float num2 = 2348.943f;
            float num3 = 2.789f;
            float num4 = 284.284f;
            float num5 = 88.821f;
            float num6 = 790.380f;

            Console.WriteLine($"{num1,9:n}");
            Console.WriteLine($"{num2,9:n}");
            Console.WriteLine($"{num3,9:n}");
            Console.WriteLine($"{num4,9:n}");
            Console.WriteLine($"{num5,9:n}");
            Console.WriteLine($"{num6,9:n}");

            Console.ReadLine();
        }
    }
}
