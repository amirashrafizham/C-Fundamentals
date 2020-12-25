using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new double[3];
            numbers[0] = 12.7;
            numbers[1] = 13.5;
            Console.WriteLine(numbers[0]+numbers[1]);

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
