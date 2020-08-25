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
        }

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

        public static void Task5()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(Math.Pow(i,3));
            }
        }

        public static void Task6()
        {
            double i, sum = 0;

            for (i = 1; i <= 20; i++)
                sum = sum + 1 / i;

            Console.WriteLine(sum);
        }

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

    }
}

