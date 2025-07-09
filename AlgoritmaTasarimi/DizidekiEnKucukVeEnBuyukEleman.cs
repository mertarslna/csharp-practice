using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    internal class DizidekiEnKucukVeEnBuyukEleman
    {
        public static int[] Find(int[] dizi)
        {
            /*
             * EXAMPLE CODE
            int[] dizi = { 1, 42, 35, 34, 346, 6, 47, -235, 235 - 23, 5 };
            foreach (int max_min in DizidekiEnKucukVeEnBuyukEleman.Find(dizi))
            {
                Console.WriteLine(max_min);
            }
            */
            int[] d = new int[2];
            d[0] = dizi[0]; // minimum
            d[1] = dizi[1]; // maximum

            for (int i = 1;i < dizi.Length; i++) {
                if (d[0] > dizi[i])
                    d[0] = dizi[i];
                else if (d[1] < dizi[i])
                    d[1] = dizi[i];
            }
            return d;
        }
    }
}
