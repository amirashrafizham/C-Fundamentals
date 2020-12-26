using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // unsigned integer => positive whole number 
            uint naturalNumber = 23;

            // integer => negative or positive whole number 
            int integerNumber = -23;

            // float => single-precision floating point.
            // F suffix => float literal 
            float realNumber = 2.3F;

            // double => double-precision floating point.
            double anotherRealNumber = 2.3;

            //Write how you could write the number 2 million

            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            // check whether decimalNotation is equals to binaryNotation
            Console.WriteLine($"{decimalNotation == binaryNotation}");


            // Checking the number size of int and double type
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range { int.MinValue:N0} to { int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range { double.MinValue:N0} to { double.MaxValue:N0}.");

            // Why you shouldn't use double instead of decimal
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} is 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} is not 0.3");
            }

            decimal c = 0.1m; // M suffix means a decimal literal value
            decimal d = 0.2m;
            if (c + d == 0.3m)
            {
                Console.WriteLine($"{c} + {d} is 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} is 0.3");
            }




        }
    }
}
