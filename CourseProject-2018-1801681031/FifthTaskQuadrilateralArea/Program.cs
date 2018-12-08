using System;

namespace FifthTaskQuadrilateralArea
{
    class Program
    {
        /*Задача 166, страница 100
        Да се намери лицето на изпъкнал четириъгълник, ако са зададени
        а) координатите на върховете му 
        б) дължините на страните му и единият диагонал
        */

        public static void NewMethod(double a, double c, double S, double d1)
        {
            double sin = (a / c);

            double d2 = ((S * 2) / d1 * sin);

            Console.WriteLine("Диагонала на изпъкналия четириъгълник е: {0}", d2);
        }

        public static void Main()
        {
            Console.WriteLine("Програмата ще пресметне лицето на четириъгълник:");

            Console.Write("Въведи страната а :");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведи страната b :");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Въведи страната c :");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Въведи страната d :");
            double d = double.Parse(Console.ReadLine());

            double S = Math.Sqrt(a * b * c * d);

            Console.WriteLine($"Лицето на изпъкналия четириъгълник е: {S}");

            Console.Write("Въведи диагонала d1:");
            double d1 = double.Parse(Console.ReadLine());

            NewMethod(a, c, S, d1);

        }
    }
}
