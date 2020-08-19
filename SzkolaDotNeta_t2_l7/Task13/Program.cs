using System;

namespace Task13
{
    class Program
    {
        //13. Napisz program, który będzie posiadał proste menu(wg.Wzoru poniżej) I
        //będzie prostym kalkulatorem
        //Podaj pierwszą liczbę:
        //…
        //Podaj drugą liczbę:
        //…
        //Podaj numer operacji do wykonania:
        //1. Dodawanie
        //2. Odejmowanie
        //3. Mnożenie
        //4. Dzielenie
        //…
        //Twój wynik to:
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            double wynik;

            Console.WriteLine("Choose the option:");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");

            int chosenOption = int.Parse(Console.ReadLine());

            switch (chosenOption)
            {
                case 1:
                    {
                        wynik = firstNumber + secondNumber;
                        Console.WriteLine($"Action result: {wynik}");
                    }
                    break;

                case 2:
                    {
                        wynik = firstNumber - secondNumber;
                        Console.WriteLine($"Action result: {wynik}");
                    }
                    break;

                case 3:
                    {
                        wynik = firstNumber * secondNumber;
                        Console.WriteLine($"Action result: {wynik}");
                    }
                    break;

                case 4:
                    {
                        wynik = firstNumber / secondNumber;
                        Console.WriteLine($"Action result: {wynik}");
                    }
                    break;

                default:
                    Console.WriteLine("Select the correct menu number");
                    break;
            }    

        }
    }
}
