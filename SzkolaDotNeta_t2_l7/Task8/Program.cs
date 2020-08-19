using System;

namespace Task8
{
    class Program
    {
        //8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
        //na studiach wg.Następujących kryteriów:
        //Wynik z Matury z matematyki powyżej 70
        //Wynik z fizyki powyżej 55
        //Wynik z chemii powyżej 45
        //Łączny wynik z 3 przedmiotów powyżej 180
        //Albo
        //Wynik z matematyki i jednego przedmiotu powyżej 150
        //Dane testowe:
        //Matematyka 80
        //Fizyka 71
        //Chemia 0
        //Rezultat w terminalu :
        //Kandydat dopuszczony do rekrutacji

        static void Main(string[] args)
        {
            Console.WriteLine("The program checks whether the candidate can be accepted for recruitment");

            Console.WriteLine("Enter the math result:");
            double mathResult = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the result from physics:");
            double physicsResult = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the result of chemistry:");
            double chemistryResult = double.Parse(Console.ReadLine());

            double sum = mathResult + physicsResult + chemistryResult;

            if ((mathResult > 70 && physicsResult > 55 && chemistryResult > 45 && sum > 180) || 
                ((mathResult + physicsResult > 150) || (mathResult + chemistryResult > 150)))
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else
            {
                Console.WriteLine("Candidate not admitted to recruitment");
            }
        }
    }
}
