using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: (DONE!!!) Leaving instructions for readability: 

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evens = new List<int>();
            var odds = new List<int>();

            foreach (int i in Array) {
                if (i % 2 == 0) {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            Console.WriteLine("odds:");
            foreach (int i in odds) {
                if (i == odds[evens.Count - 1])
                {
                   Console.Write($"{i}");
                }
                else
                {
                   Console.Write($"{i},");
                }

            }
            Console.WriteLine("\nevens:");
            foreach (int i in evens)
            {
                if (i == evens[evens.Count-1])
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($"{i},");
                }

            }

        }
    }
}
