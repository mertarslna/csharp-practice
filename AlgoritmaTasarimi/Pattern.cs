using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    internal class Pattern
    {
        /// <summary>
        /// Desen oluşturur.
        /// </summary>
        /// <param name="c">Karakter tanımı</param>
        /// <param name="n">Tekrar sayısı</param>
        public static void Create1(char c = '*', int n=5)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(c, i));
            }
        }
        // @Override
        public static void Create1(string c = "*", int n = 5)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++) 
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Desen oluşturur.
        /// </summary>
        /// <param name="c">Karakter tanımı</param>
        /// <param name="n">Tekrar sayısı</param>
        public static void Create2(char c = '!', int n = 5)
        {
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(new string(c, i));
            }
        }
        // @Override
        public static void Create2(string c = "!", int n = 5)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}
