using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BinarySearch
{
    public static class Validate
    {
        public static int Number(string input)
        {
            var num = 0;
            while (!int.TryParse(input, out num))
            {
                Console.Write($"Please enter an integer: ");
                input = Console.ReadLine();
            }

            return num;
        }

        public static string YesNo(string input)
        {
            input = input.ToLower().Trim();
            while (!Regex.IsMatch(input, "^[yn]$"))
            {
                Console.Write("Please enter y or n: ");
                input = Console.ReadLine().ToLower().Trim();
            }

            return input;
        }
    }
}
