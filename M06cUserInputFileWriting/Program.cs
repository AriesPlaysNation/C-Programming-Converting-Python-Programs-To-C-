using System;
using System.IO;
using System.Text;

namespace M06cUserInputFileWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            StreamWriter sw = new StreamWriter("name.txt", true, Encoding.UTF8);

            try
            {
                //System.IO.File.OpenWrite("name.txt").Write(name);
                sw.WriteLine(name + "\n" + age + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing the finally block");
                Console.ReadLine();
            }
            sw.Close();
            
        }
    }
}
