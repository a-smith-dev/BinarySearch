using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsortedList = new List<int> { 15, 10, 8, 3, 18, 17, 20 };

            DisplayCurrentList(unsortedList, "unsorted");

            var sortedList = Sort.Bubble(unsortedList);
            DisplayCurrentList(unsortedList, "sorted");

            CheckNumberLoop(sortedList);
        }

        private static void DisplayCurrentList(List<int> currentList, string message)
        {
            Console.WriteLine($"The {message} list is as follows:");
            foreach (var num in currentList)
            {
                Console.Write($"{num} ");
            }
        }

        private static void CheckNumberLoop(List<int> sortedList)
        {
            do
            {
                Console.Write("\n\nPlease enter a number to check if it's in the list: ");
                var number = Validate.Number(Console.ReadLine());

                if (Search.Binary(sortedList, number))
                {
                    Console.WriteLine($"{number} is in the list!");
                }
                else
                {
                    Console.WriteLine($"{number} is not in the list.");
                }

                Console.Write("Would you like to check another number? (y/n) ");
            } while (Validate.YesNo(Console.ReadLine()) == "y");
        }
    }
}
