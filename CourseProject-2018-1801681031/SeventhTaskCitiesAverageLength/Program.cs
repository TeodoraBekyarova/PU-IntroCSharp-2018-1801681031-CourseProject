using System;

namespace SeventhTaskCitiesAverageLength
{
    class Program
    {
        /*Задача 372 а) и), страница 211
        Елементите на масив са имена на населени места.Да се съставят методи за:
        а) въвеждане на елентите на масив (не повече от 50)
        и) намиране на средната дължина на име на населено място и изваждане на екрана на всички населени места, чиито имена са с по-малка дължина от средната
         */

        public static void Main(string[] args)
        {
            string[] cities;
            int broi = 0;
            do
            {
                Console.Write("Въведи брой на елементите: ");
                broi = int.Parse(Console.ReadLine());
            }
            while (broi < 1 || broi > 50);

            cities = new string[broi];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write("Въведете град номер {0}: ", i + 1);
                cities[i] = Console.ReadLine();
            }

            int sum = 0;
            for (int i = 0; i < cities.Length; i++)
            {
                sum += cities[i].Length;
            }
            double average = sum * 1.0 / broi;
            Console.WriteLine("Средна стойност: " + average);

            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i].Length < average)
                {
                    Console.WriteLine("дължината на {0} е по-малка от средната!", cities[i]);
                }
            }

            Console.ReadKey(true);
        }
    }
}
