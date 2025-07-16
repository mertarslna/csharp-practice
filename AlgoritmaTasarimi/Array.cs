using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    internal class Array
    {
        /// <summary>
        /// Tek boyutlu bir dizi oluşturur ve rastgele sayılarla doldurur.
        /// </summary>
        /// <param name="n"> Dizinin uzunluğunu belirtir.</param>
        /// <returns>Belirtilen uzunlukta rastgele sayılardan oluşan dizi döner.</returns>
        public static int[] Create(int n) 
        {
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1,100);
            }
            return array;
        }
        /// <summary>
        /// Parametre olarak verilen dizideki en küçük ve en büyük sayıları bulur.
        /// </summary>
        /// <param name="array">Dizi</param>
        /// <returns></returns>
        public static int[] FindMinMax(int[] array)
        {
            /* 
         * Example Code For Find Method
        int[] array = { 1, 42, 35, 34, 346, 6, 47, -235, 235 - 23, 5 };
        foreach (int min_max in Dizi.FindMinMax(array))
        {
            Console.WriteLine(min_max);
        }
        */
            int[] d = new int[2];
            d[0] = array[0]; // min
            d[1] = array[0]; // max

            for (int i = 1; i < array.Length; i++)
            {
                if (d[0] > array[i])
                    d[0] = array[i];
                else if (d[1] < array[i])
                    d[1] = array[i];
            }
            return d;
        }
        /// <summary>
        /// Parametre olarak verilen dizideki en küçük sayıyı bulur.
        /// </summary>
        /// <param name="array">Dizi</param>
        /// <returns>Minimum</returns>
        public static int FindMin(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }
            return min;
        }
        /// <summary>
        /// Parametre olarak verilen dizideki en büyük sayıyı bulur.
        /// </summary>
        /// <param name="array">Dizi</param>
        /// <returns>Maximum</returns>
        public static int FindMax(int[] array)
        {
            int max= array[0]; // max

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            return max;
        }
        /// <summary>
        /// Parametre olarak verilen dizideki sayıların ortalamasını hesaplar.
        /// </summary>
        /// <param name="array">Dizi</param>
        /// <returns>Aritmetik Ortalama</returns>
        public static double Average(int[] array)
        {
            double sum = 0;

            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum/array.Length;
        }
        /// <summary>
        /// Parametre olarak verilen diziyi ekrana yazdırır.
        /// </summary>
        /// <param name="array">Dizi</param>
        public static void Print(int[] array)
        {
            /*
             * Example Code For Print Method
            int[] array = { 1, 42, 35, 34, 346, 6, 47, -235, 235 - 23, 5 };
            Dizi.Print(array);
            */
            foreach (int item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Parametre olarak verilen dizinin standart sapmasını hesaplar.
        /// </summary>
        /// <param name="array">Dizi</param>
        /// <returns>Standart Sapma</returns>
        public static double StandardDeviation(int[] array)
        {
            double result=0;
            double average = Average(array);

            for (int i = 0; i < array.Length; i++)
            {
                result += Math.Pow(array[i] - average, 2);
            }
            result = Math.Sqrt(result / array.Length-1);

            return result;
        }
        /// <summary>
        /// Parametre olarak verilen dizideki çift sayıların sayısını döner.
        /// </summary>
        /// <param name="array">Dizi</param>
        /// <returns></returns>
        public static int EvenCount(int[] array)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Parametre olarak verilen dizideki tek sayıların sayısını döner.
        /// </summary>
        /// <param name="array">Dizi</param>
        /// <returns></returns>
        public static int OddCount(int[] array)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Parametre olarak verilen dizideki çift sayılardan oluşan yeni bir dizi oluşturur.
        /// </summary>
        /// <param name="array">Dizi</param>
        /// <returns></returns>
        public static int[] CreateEven(int[] array)
        {
            int[] newArray = new int[EvenCount(array)];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            return newArray;
        }
        /// <summary>
        /// Parametre olarak verilen dizideki tek sayılardan oluşan yeni bir dizi oluşturur.
        /// </summary>
        /// <param name="array">Dizi</param>
        /// <returns></returns>
        public static int[] CreateOdd(int[] array)
        {
            int[] newArray = new int[OddCount(array)];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            return newArray;
        }

    }
}