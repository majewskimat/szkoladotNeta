using System;

namespace Task12
{
    class Program
    {
        //12. Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
        //nazwę
        //Dane testowe : 4
        //Rezultat w terminalu :
        //Czwartek
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the day of the week:");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("You entered wrong number");
                    break;
            }

        }
    }
}
