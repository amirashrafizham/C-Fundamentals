using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new [] {12.7, 10.3, 6.11};
            double results;
            results = 0;
            foreach (double number in numbers)

            {
               results += number;
            }

            Console.WriteLine(results);
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]} !");
            }
            else
            {
                Console.WriteLine("Hello");
            }
            Console.ReadLine();
        }
    }
}
