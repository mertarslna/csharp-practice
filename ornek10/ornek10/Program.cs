using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // {1,3,4,34,41,56,89} dizisindeki sayılardan hangileri 3'ün katıdır
            int[] sayilar = { 1, 3, 4, 34, 41, 56, 89, 12};

            for (int i = 0; i < sayilar.Length; i++)
                if (sayilar[i]%3==0)
                    Console.WriteLine(sayilar[i]);
                
            Console.ReadKey();
        }
    }
}
