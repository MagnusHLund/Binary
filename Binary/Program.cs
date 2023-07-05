using System;
using System.Diagnostics.Metrics;

namespace Binary
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random random = new Random();

            while (true)
            {
                Console.Write(random.Next(2));
            }
        }
    }
}