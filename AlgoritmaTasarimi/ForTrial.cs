using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    internal class ForTrial
    {
        public static void Process()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("{0} -> {1}", i, i * i);
            }
        }

        // @Override
        public static void Process(int baslangic,int bitis,int artis)
        {
            if (baslangic < bitis)
            {
                for (int i = baslangic; i <= bitis; i += artis)
                {
                    Console.WriteLine("{0} -> {1}", i, i * i);
                }
            }
            else 
            {
                for (int i = baslangic; i >= bitis; i -= artis)
                {
                    Console.WriteLine("{0} -> {1}", i, i * i);
                }
            }
        }
    }
}
