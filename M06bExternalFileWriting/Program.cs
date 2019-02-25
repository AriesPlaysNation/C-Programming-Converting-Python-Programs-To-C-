using System;
using System.IO;
using System.Text;

namespace M06bExternalFileWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            try
            {
                // Open the file
                StreamWriter sw = new StreamWriter("F:\\School\\IntroToSoftwareDev\\Conversion\\sampleWrite.txt", true, Encoding.ASCII);

                // Write out the numbers 1 to 10 on the same line.
                for (x = 0; x < 10; x++)
                {
                    // Use "\n" for text on new line. Don't use for all on same line.
                    sw.Write(x + "\n");
                }

                // Close the file
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing the finally block.");
            }
        }
    }
}
