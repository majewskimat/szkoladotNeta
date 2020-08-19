using System;

namespace Task6
{
    class Program
    {
        //6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
        //wymyśloną kategorię wzrostu.
        //Dane testowe : 140
        //Rezultat w terminalu :
        //Jesteś krasnoludem

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height (cm):");
            int height = int.Parse(Console.ReadLine());

            if (height < 150)
                Console.WriteLine("You are a dwarf");
            else if (height >= 150 && height < 160)
                Console.WriteLine("You are an elf");
            else if (height >= 160 && height < 170)
                Console.WriteLine("You are Asian");
            else if (height >= 170 && height < 180)
                Console.WriteLine("You are a pawn");
            else if (height >= 180 && height < 190)
                Console.WriteLine("You are a big pawn");
            else if (height >= 190 && height < 200)
                Console.WriteLine("You are a sapling");
            else if (height >= 200)
                Console.WriteLine("You are a tree");
           
        }
    }
}
