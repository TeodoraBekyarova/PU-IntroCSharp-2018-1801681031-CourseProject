using System;

namespace FourthTaskCalculateExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 213 б), страница 126
            снимка на задачата можете да намерите в папката Условие на израза
            */

            double s = 0;

            for (int i = 2; i <= 50; i = i + 2)
            {
                s += (1.0 / i);
            }
            Console.WriteLine($"Резултата от умножението: {s}");
        }
    }
}
