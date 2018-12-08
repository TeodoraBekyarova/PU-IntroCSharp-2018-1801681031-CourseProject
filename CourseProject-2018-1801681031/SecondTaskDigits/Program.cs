using System;

namespace SecondTaskDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 12, страница 31
            Условие: Да се напише програма, която въвежда седемцифрено число и извежда неговата 4-та цифра.
            */

            Console.Write("Въведете 7 цифрено число: ");
            int value = int.Parse(Console.ReadLine());
            int number = Math.Abs(value);

            if (number < 1000000 || number > 9999999)
            {
                Console.WriteLine("Числото което въведохте не е 7 цифрено!");
            }
            else
            {
                int fourthDigit = number % 1000000 % 100000 % 10000 / 1000;
                Console.WriteLine($"Четвъртата цифра от твоето число {number} е {fourthDigit}.");
            }
        }
    }
}
