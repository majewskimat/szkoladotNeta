using System;

namespace Task4
{
    class Program
    {
        //4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
        //jest rokiem przestępnym.
        //Dane testowe : 2016
        //Rezultat w terminalu :
        //2016 jest rokiem przestępnym

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4) == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}
