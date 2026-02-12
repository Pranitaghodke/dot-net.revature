using System;

namespace Day2Assignment
{
    public class Section10
    {
        public static void Run()
        {
            MathOperatorsExample();
        }

        static void MathOperatorsExample()
        {
            int a = 10;
            int b = 3;

            int sum = a + b;
            int diff = a - b;
            int product = a * b;
            double ratio = (double)a / b;
            int remainder = a % b;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + diff);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Ratio: " + ratio);
            Console.WriteLine("Remainder: " + remainder);
            Console.WriteLine("......................");
        }
    }
}