using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofApples = 12;
            decimal pricePerApple = 0.35m;

            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberofApples,
                arg1: pricePerApple * numberofApples
           );


            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count"
            );

            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount
            );

            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );

            Console.Write("What is your name and press ENTER: ");
            string firstName = Console.ReadLine();
            Console.Write("What is your age and press ENTER: ");
            string age = Console.ReadLine();
            Console.Write($"Hello {firstName}, you look good for {age}\n");

            Console.Write("Type in any key combination: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers
            );
        }
    }

}
