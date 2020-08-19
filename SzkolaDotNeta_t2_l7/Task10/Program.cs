using System;

namespace Task10
{
    class Program
    {
        //10. Napisz program, który sprawdzi, czy z 3 podanych długości można
        //stworzyć trójkąt
        //Dane testowe : 40 55 65
        //Rezultat w terminalu :
        //Można zbudować trójkąt

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sides of the triangle");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("You can build a triangle");
            }
            else
                Console.WriteLine("You can't build a triangle");

        }
    }
}
