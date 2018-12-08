using System;

namespace SixthTaskSumK
{
    class Program
    {
        /*Задача 404, страница 222
         Да се въведе едномерен целочислен масив с дължина (брой елементи) в инетрвала [2;50]. Да се контролира въвеждането на дължината в този интервал
         а) да се напише метод Sum (k), който връща сумата от всички елементи на масива, по-големи от параметъра (фомалният параметър k се 
         въвежда от потребителя). След изчислението, сумата да се отпечата на екрана.
         б)Да се намери и отпечата на екрана броят на всички трицифрени елементи на масива, сумата на чиито съставни цифри е четно число
         */

        public static void ArraySum()
        {
            int arrlength = 0;
            do
            {
                Console.Write("Въведете дължина на масива: ");
                arrlength = int.Parse(Console.ReadLine());
            }
            while (arrlength > 50 || arrlength < 2);
            int[] arrNums = new int[arrlength];

            ArraySum_Fill(arrNums);
            ArraySum_Sum(arrNums);
            ArraySum_Filter3(arrNums);
        }

        public static int[] ArraySum_Fill(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведете число {0} от масива: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        public static void ArraySum_Sum(int[] arr)
        {
            Console.Write("Въведете К: ");
            int k = int.Parse(Console.ReadLine());
            int sumOverK = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > k) sumOverK += arr[i];
            }
            Console.WriteLine("Сумата от числата по-големи от К: " + sumOverK);
        }

        public static void ArraySum_Filter3(int[] arr)
        {
            int numOfFilter3 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 1000 && arr[i] > 99)
                {
                    int firstNum = arr[i] / 100;
                    int secNum = arr[i] % 100 / 10;
                    int thirdNum = arr[i] % 10;
                    int sumAllNums = firstNum + secNum + thirdNum;
                    if (sumAllNums % 2 == 0) numOfFilter3++;
                }
            }
            Console.WriteLine("Броят на трицифрените числа, сбора на чиито съставни цифри е положително число: " + numOfFilter3);
        }

        static void Main(string[] args)
        {
            ArraySum();
            Console.ReadKey(true);
        }
    }
}
