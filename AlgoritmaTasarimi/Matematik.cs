using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    internal class Matematik
    {
        public const double pi = 3.1415926535897931;
        public const double e = 2.7182818284590452;
        public static double MutlakDeger(double n)
        {
            if (n >= 0) return n;
            else return -1 * n;
        }
        public static double UsAlma(double taban, int us)
        {
            double result = 1;
            for (int i = 0; i < us; i++)
            {
                result = result * taban;
            }
            return result;

        }
        public static int TekToplam(int baslangic, int son)
        {
            int toplam = 0;
            if (baslangic % 2 == 0)
            {
                for (int i = baslangic + 1; i < son; i += 2)
                {
                    toplam += i;
                }
            }
            else
            {
                for (int i = baslangic; i < son; i += 2)
                {
                    toplam += i;
                }
            }
            return toplam;
        }
        public static int CiftToplam(int baslangic, int son)
        {
            int toplam = 0;
            if (baslangic % 2 == 0)
            {
                for (int i = baslangic; i < son; i += 2)
                {
                    toplam += i;
                }
            }
            else
            {
                for (int i = baslangic + 1; i < son; i += 2)
                {
                    toplam += i;
                }
            }
            return toplam;
        }
        public static void CarpimTablosu() {
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Console.Write("{0}x{1} ",i,k);
                }
                Console.WriteLine();
            }
        }
    }
}
