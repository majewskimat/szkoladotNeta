using System;

namespace Task7
{
    class Program
    {
        //7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
        //która jest największa
        //Dane testowe:
        //25
        //63
        //79
        //Rezultat w terminalu :
        //79 jest największa z podanych

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.WriteLine($"{a} is the largest given ");
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine($"{b} is the largest given ");
            }
            else
            {
                Console.WriteLine($"{c} is the largest given ");
            }
            



        }
    }
}
