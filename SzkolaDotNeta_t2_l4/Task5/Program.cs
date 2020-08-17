using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your gender:");
            char gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter your phone number:");
            long phonenumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter e-mail adress:");
            string email = Console.ReadLine();

            Console.WriteLine("What is your height ? (cm)");
            byte height = byte.Parse(Console.ReadLine());

            Console.WriteLine("What is your weight ? (kg)");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine($"You are {name} {surname}. You are {age} years old. Your phone number is {phonenumber}. Your e-mail: {email}. Your are {height}cm tall and {weight} kilos weight.");

        }
    }
}
