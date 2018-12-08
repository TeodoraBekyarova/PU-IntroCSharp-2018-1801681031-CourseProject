using System;

namespace FirstTaskNumeralSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Числото 2031 представено в различни бройни системи.");
            int value = 2031;
            string binary2 = Convert.ToString(value, 2);
            string binary8 = Convert.ToString(value, 8);
            string binary16 = Convert.ToString(value, 16);
            Console.WriteLine("Представено в двоична бройна система: " + binary2);
            Console.WriteLine("Представено в осмична бройна система: " + binary8);
            Console.WriteLine("Представено в шестнайсетична бройна система: " + binary16);
        }
    }
}
