using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            RunErrorHandling();
            Console.ReadKey();
        }

        static void RunErrorHandling()
        {
            Handlind.TryCatchMe.MyErrors();
        }
    }
}
