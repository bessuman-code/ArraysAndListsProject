using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:
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

            Console.WriteLine("Let's Go!!!!!");
            ForEachLoop();
            ForLoop();
            
        }

        public static void ForEachLoop()

        {
            var intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenList = new List<int>();
            var oddList = new List<int>();
            Console.WriteLine($"This is for the foreach Loop");
            foreach (var evenOrodd in intArray )
            {
                int even = evenOrodd % 2;
                if (even == 0)
                {
                    evenList.Add(evenOrodd);
                }else
                {
                    oddList.Add(evenOrodd);
                }   
            }
            foreach (var listOfEvens in evenList)
            {
                Console.WriteLine($"Even List: {listOfEvens}");
            }
            foreach (var listOfOdds in oddList)
            {
                Console.WriteLine($"Odd List: {listOfOdds}");
            }

        }
        public static void ForLoop()
        {
            var intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenList = new List<int>();
            var oddList = new List<int>();
            Console.WriteLine($"This is for the for Loop");
            for (int i = 0; i < intArray.Length; i++)
            {
                int even = intArray[i] % 2;
                if (even == 0)
                {
                    evenList.Add(intArray[i]);
                }else
                {
                    oddList.Add(intArray[i]);
                }
                
            }
            foreach (var listOfEvens in evenList)
            {
                Console.WriteLine($"Even List: {listOfEvens}");
            }
            foreach (var listOfOdds in oddList)
            {
                Console.WriteLine($"Odd List: {listOfOdds}");
            }

        }
    }
}
