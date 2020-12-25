using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new[] { 12.7, 10.3, 6.11 };
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            double results;
            results = 0;
            foreach (double number in grades)
            {
                results += number;
            }
            // To find the sum of the List 
            Console.WriteLine(results);

            // To find the average of the List 
            results /= grades.Count;
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
