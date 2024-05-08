 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı tarafından seçilecek olan 4 işlem tipine göre hesaplama yapınız.

            Console.WriteLine("Yapılacak işlemi seçiniz.");
            Console.Write("1/Toplama, 2/Çıkarma, 3/Bölme, 4/Çarpma: ");
            int secenek = Convert.ToInt32(Console.ReadLine());

            Console.Write("İlk sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            var sonuc = 0;
            if (secenek == 1)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (secenek == 2)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (secenek == 3)
            {
                sonuc = sayi1 / sayi2;
            }
            else if (secenek == 4)
            {
                sonuc = sayi1 * sayi2;
            }
            else
            {
                Console.WriteLine("İşlem için geçersiz sayı girişi yapıldı.");
            }

            Console.Write("Sonuç: ");
            Console.WriteLine(sonuc);
            Console.ReadKey();

        }
    }
}
