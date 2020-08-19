using System;

namespace Task1
{
    class Program
    {
        //1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
        //one równe czy nie.
        //Dane testowe:
        //a : 5
        //b : 5
        //Rezultat w terminalu :
        //5 i 5 są równe

        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal");
            }

        }
    }
}
