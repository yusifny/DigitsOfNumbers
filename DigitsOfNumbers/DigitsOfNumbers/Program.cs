using System;
using static  System.Console;

namespace DigitsOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number: ");
            int number = Convert.ToInt32(ReadLine());
            int numberB = 0;
            while (number>0)
            {
                number /= 10;
                numberB++;
            }

            WriteLine($"The entered number has {numberB} digit(s).");
        }
    }
}