using System;

namespace Task5
{
    class Program
    {
        //5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
        //uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
        //prezydenta.
        //Dane testowe : 21
        //Rezultat w terminalu :
        //Możesz zostać posłem

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 21)
            {
                Console.WriteLine("You can become an MP");

                if (age >= 30)
                {
                    Console.WriteLine("You can become a senator");

                    if (age >= 35)
                    {
                        Console.WriteLine("You can become president");
                    }
                }

            }
            else
            {
                Console.WriteLine("You are too young to be an MP, senator or president");
            }
            
        }
    }
}
