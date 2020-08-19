using System;

namespace Task3
{
    class Program
    {
        //3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
        //jest dodatnia czy ujemna.
        //Dane testowe : 14
        //Rezultat w terminalu :
        //14 jest liczbą dodatnią

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else if (number == 0)
            {
                Console.WriteLine($"{number} is neither positive nor negative");
            }
            else
            {
                Console.WriteLine($"{number} is negative");
            }
        }
    }
}
