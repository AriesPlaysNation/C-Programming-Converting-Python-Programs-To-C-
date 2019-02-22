using System;

namespace M04aCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool keepGoing = true;
            
            
            while (keepGoing == true)
            {

                Console.Write("Enter the amount of sales: ");
                string usales = Console.ReadLine();

                Console.Write("Enter the commission rate: ");
                string ucommRate = Console.ReadLine();

                float sales = float.Parse(usales);
                float commRate = float.Parse(ucommRate);

                Console.WriteLine(sales * commRate);

                Console.Write("Do you want to calculate another commission? (Enter y for yes): ");
                string continues = Console.ReadLine();

                if (continues != "y")
                {
                    keepGoing = false;
                }
                
            } 
        }
    }
}
