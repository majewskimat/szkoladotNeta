using System;
using System.Diagnostics.Tracing;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SzkolaDotNeta_t2_l8
{
    class Program
    {
        //1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Console.WriteLine(Task3(10));
            //Task4();
            //Task5();
            //Task6();
            //Task7(20);
            //Task8();
            //Task9();
            //Task10();
        }

        //1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
        public static void Task1()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }

            }
        }
        //2. Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z
        //zakresu 0 – 1000.
        public static void Task2()
        {
            int i = 0;
            do
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            } while (i <= 1000);
        }

        //3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
        public static string Task3(int input)
        {
            StringBuilder sbuilder = new StringBuilder();

            int firstFibbo = 0, secondFibbo = 1, replacement;

            for (int i = 0; i < input; i++)
            {
                sbuilder.Append((firstFibbo + secondFibbo).ToString() + ",");

                replacement = secondFibbo;
                secondFibbo = firstFibbo + secondFibbo;
                firstFibbo = replacement;
            }
            return sbuilder.ToString();

        }

        //4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
        //liczby w formie jak poniżej:
        //1
        //2 3
        //4 5 6
        //7 8 9 10
        public static void Task4()
        {
            int counter = 1, space = 1;

            Console.WriteLine("Enter an integer:");
            int integer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= integer; i++)
            {
                if (counter < space)
                {
                    Console.Write(i + " ");
                    counter++;
                }
                else
                {
                    Console.Write(i + "\r\n");
                    counter = 1;
                    space++;
                }
            }

        }

        //5. Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
        public static void Task5()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(Math.Pow(i,3));
            }
        }

        //6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
        //1 + ½ + 1/3 + ¼ itd.
        public static void Task6()
        {
            double i, sum = 0;

            for (i = 1; i <= 20; i++)
                sum = sum + 1 / i;

            Console.WriteLine(sum);
        }

        //7. Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
        //przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
        //    *
        //   ***
        //  *****
        // *******
        //*********
        // *******
        //  *****
        //   ***
        //    *
        public static int Task7(int length)
        {
            //top of the diamond
            for (int i = 0; i <= length; i++)
            {
                for (int j = length; j > i; j--)
                    Console.Write(" ");

                for (int k = 1; k <= i + 1; k++)
                    Console.Write(" *");

                Console.WriteLine();
            }
            //bottom of the diamond
            for (int i = 0; i < length; i++)
            {
                for (int j = -1; j < i; j++)
                    Console.Write(" ");

                for (int k = 0; k < (length - i); k++)
                    Console.Write(" *");

                Console.WriteLine();
            }
            return length;
        }

        //8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.Np.
        //Testowe dane:
        //Abcdefg
        //Rezultat
        //Gfedcba

        public static void Task8()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            for (int i = (str.Length - 1); i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }

        //9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
        public static void Task9()
        {
            Console.WriteLine("Enter a decimal:");
            int dec = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (dec > 0)
            {
                remainder = dec % 2;
                dec /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine($"Binary: {result}");

        }

        //10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
        public static int GCD(int a, int b)
        {
            int helper;

            while(b!=0)
            {
                helper = b;
                b = a % b;
                a = helper;
            }
            return a;
        }
        public static void Task10()
        {
            Console.WriteLine("Enter two integers: ");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"LCM from {firstNum} and {secondNum} = " + firstNum/GCD(firstNum, secondNum)*secondNum);

        }
            


    }
}

