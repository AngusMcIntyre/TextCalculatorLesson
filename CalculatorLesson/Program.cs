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
            }
        }
    }
}
