using System;
using System.IO;

namespace M06aExternalFileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {

                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("F:\\School\\IntroToSoftwareDev\\Conversion\\sample.txt");

                // Reads the first line of file
                line = sr.ReadLine();

                //Continue reading until the end of the txt file
                while (line != null)
                {
                    // Write the line to console window
                    Console.WriteLine(line);

                    // Read the next line in the file
                    line = sr.ReadLine();
                }
                // Close the file
                sr.Close();

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
    }
}

