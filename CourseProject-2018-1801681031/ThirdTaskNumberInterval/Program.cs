using System;

namespace ThirdTaskNumberInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 36 в), страница 37
            в) х принадлежи на интервала [2,5] или на интервала [-1,1]
            */

            Console.WriteLine("Въведете х и програмата ще провери дали е в интервала [2,5] или в интервала [-1,1]");

            double x = double.Parse(Console.ReadLine());

            if (x >= 2 && x <= 5)
            {
                Console.WriteLine($"{x} принадлежи на интервала [2,5]");
            }
            else
            {
                Console.WriteLine($"{x} не принадлежи на интервала [2,5]");
            }

            if (x >= -1 && x <= 1)
            {
                Console.WriteLine($"{x} принадлежи на интервала [-1,1]");
            }
            else
            {
                Console.WriteLine($"{x} не принадлежи на интервала [-1,1]");
            }
        }
    }
}
