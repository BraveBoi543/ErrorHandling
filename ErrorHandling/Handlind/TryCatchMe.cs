using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ErrorHandling.Handlind
{
    class TryCatchMe
    {

        public static void MyErrors()
        {
            try
            {
                using (StreamReader sr = File.OpenText("bob.txt"))
                {
                    Console.WriteLine($"The first line of the text is: {sr.ReadLine()}");
                    Console.WriteLine($"The second line of the text is: {sr.ReadLine()}");

                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"The file was not found: {e}");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"The Directory Could not be found: {e}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"File couldn't be opened: {e}");
            }
        }

    }
}
