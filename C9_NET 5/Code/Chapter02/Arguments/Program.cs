using System;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"There are {args.Length} arguments.");

            foreach (string arg in args)
            {
               Console.WriteLine(arg);
            }

        }
    }
}

