using System;
using static System.Console;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, s;
            Console.WriteLine("Enter the length of the rectangle");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle");
            b = Double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("value a and b must be greater than zero");
            }
            else
            {
                s = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 2);
                Console.WriteLine("The length of the diagonal is: " + s);
            }
        }
    }
}
