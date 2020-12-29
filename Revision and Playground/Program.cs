using System;
using System.Collections;
using System.Collections.Generic;
namespace Revision_and_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int actualNumber = 5;
            int limit = 3;
            int guessNumber;
            int[] guessList = new int[limit];

            for (int counter = 0; counter < limit; counter++)
            {
                Console.Write("Guess a number: ");
                guessNumber = Convert.ToInt32(Console.ReadLine());

                guessList[counter] = guessNumber;
                if (guessNumber == actualNumber)
                {
                    Console.WriteLine($"Correct! The actual number is {actualNumber}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Sorry try again! You have {limit - counter+1} tries remaining. Below is your list of previous guesses:");
                    for (int counter2 = 0; counter2 < counter+1; counter2++)
                    {
                        Console.Write(guessList[counter2]+" ");
                    }
                    Console.WriteLine("\n");
                }
            }

            Console.ReadLine();

        }

    }

}

