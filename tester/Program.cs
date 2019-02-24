using System;

namespace tester
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = ShowDouble(5); // Assigns an int called value to the value2 within method "ShowDouble", passing 5 as the original value.
            Console.WriteLine(value); // Prints out the new value of value

            Console.ReadLine();
        }

        static int ShowDouble(int number) // Assigns method "ShowDouble" allowing an int to be passed into the method, in this case "5".
        {

            return number * 2; // Calculating number * 2 and returning the value back to Main().

        }
    }
}
