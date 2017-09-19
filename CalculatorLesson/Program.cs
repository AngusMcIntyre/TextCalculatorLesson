using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please type a calculation and press ENTER.");
                string input = Console.ReadLine();
                Console.WriteLine($"You typed '{input}'.");

                int result = 0;

                // Parse the user input to get 2 operands and a an operator
                string[] operands = input.Split('+');
                if (operands.Length == 2)
                {
                    int left;
                    int right;
                    if (int.TryParse(operands[0], out left) && int.TryParse(operands[1], out right))
                    {
                        result = left + right;
                    }
                }

                Console.WriteLine($"The result of your calculation is '{result}'.");
            }
        }
    }
}
