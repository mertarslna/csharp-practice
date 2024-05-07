using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Yaşı 18'den büyük veya veli izni varsa bir işte çalışabilir durumu kontrol ediniz.
            // (if kullanmadan)

            int yas;
            string veliIzni;
            Console.Write("Yasinizi giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Veli izni giriniz(var/yok): ");
            veliIzni = Console.ReadLine();

            bool calisabilirMi = (veliIzni == "var" || yas > 18);

            string sonuc1 = (calisabilirMi ? "Çalışabilirsiniz" : "Çalışamazsınız");
            Console.WriteLine(sonuc1);

            Console.ReadKey();
        }
    }
}
