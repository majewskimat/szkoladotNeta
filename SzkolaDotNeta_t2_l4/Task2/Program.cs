using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = {'a', 'b', 'c'};

            foreach (var ch in chars.Reverse())
            {
                Console.Write(ch);  
            }


            Console.ReadKey();
        }
    }
}
