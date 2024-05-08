using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrencinin 2 yazılı ve 1 sözlü notunun ortalamasını alarak 4lük sistemindeki karşılığını yazınız
            Console.Write("1. Yazılı notunu giriniz: ");
            int yazili1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Yazılı notunu giriniz: ");
            int yazili2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sözlü notunu giriniz: ");
            int sozlu = Convert.ToInt32(Console.ReadLine());

            double ortalama = ((double)yazili1 + (double)yazili2 + (double)sozlu) / 3.0;
            short sonuc = -1;
            if (ortalama >= 0 && ortalama < 20)
            {
                sonuc = 0;
            }
            else if (ortalama >= 20 && ortalama < 40)
            {
                sonuc = 1;
            }
            else if (ortalama >= 40 && ortalama < 60)
            {
                sonuc = 2;
            }
            else if (ortalama >= 60 && ortalama < 80)
            {
                sonuc = 3;
            }
            else if (ortalama >= 80 && ortalama <= 100)
            {
                sonuc = 4;
            }
            else {
                Console.WriteLine("Geçersiz not girişi yapılmış");
            }

            Console.WriteLine($"Ortalamaniz: {ortalama} 4lük sistemde ortalamanız: {sonuc}");
            Console.ReadKey();
        }
    }
}
