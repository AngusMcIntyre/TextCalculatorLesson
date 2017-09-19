using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please type a calculation and press ENTER.");
                    string input = Console.ReadLine();
                    int result = ParseWithRegex(input);
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static int ParseWithRegex(string input)
        {
            var match = Regex.Match(input, @"(\d+)(\+)(\d+)");
            if (match.Success)
            {
                int left = int.Parse(match.Groups[1].Value);
                int right = int.Parse(match.Groups[3].Value);

                return left + right;
            }
            else
            {
                throw new Exception("Input string must contain 2 operands and an operator.");
            }
        }
    }
}
