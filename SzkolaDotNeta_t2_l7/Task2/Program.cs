using System;

namespace Task2
{
    class Program
    {
        //2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
        //jest parzysta czy nieparzysta.
        //Dane testowe : 15
        //Rezultat w terminalu :
        //15 jest liczbą nieparzystą

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            if ((number % 2) == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
            
        }
    }
}
