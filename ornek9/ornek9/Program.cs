using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ile girilen sayı arasındakilerin toplamını hesaplayınız.
            Console.Write("Sayiyi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }

            Console.WriteLine($"Toplam: {toplam}");
            Console.ReadKey();
        }
    }
}
