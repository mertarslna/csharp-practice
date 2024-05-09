using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0-100 arası rastgele tutulan bir sayıyı tahmin etme
            Random r = new Random(); 
            int sayi = r.Next(101);
            int tahmin = -1;
            Console.WriteLine(sayi);
            while (true) { 
                Console.Write("Tahmininizi giriniz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == sayi)
                {
                    Console.WriteLine("Doğru tahmin, tebrikler.");
                    break;
                }
                else 
                {
                    Console.WriteLine("Yanlış tahmin, tekrar deneyin.");
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
