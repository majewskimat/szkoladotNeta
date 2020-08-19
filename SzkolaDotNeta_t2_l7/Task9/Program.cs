using System;

namespace Task9
{
    class Program
    {
        //9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w
        //poniższych kryteriach
        //Temp< 0 – cholernie piździ
        //Temp 0 – 10 – zimno
        //Temp 10 – 20 – chłodno
        //Temp 20 – 30 – w sam raz
        //Temp 30 – 40 – zaczyna być słabo, bo gorąco
        //Temp >= 40 – a weź wyprowadzam się na Alaskę.
        //Dane testowe : 41
        //Rezultat w terminalu :
        //a weź wyprowadzam się na Alaskę.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature");
            double temp = double.Parse(Console.ReadLine());

            if (temp < 0)
                Console.WriteLine("Cold as fuck");
            else if (temp > 0 && temp < 10)
                Console.WriteLine("Cold");
            else if (temp >= 10 && temp < 20)
                Console.WriteLine("Cool");
            else if (temp >= 20 && temp < 30)
                Console.WriteLine("Not bad");
            else if (temp >= 30 && temp < 40)
                Console.WriteLine("Too hot");
            else if (temp >= 40)
                Console.WriteLine("Im moving to Alaska");

        }
    }
}
