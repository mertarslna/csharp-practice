using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ders ortalaması en az 70 puan ya da zayıfı yoksa teşekkür belgesi alabilme durumunu kontol ediniz.
            // (if kullanmadan)
            Console.Write("İlk notu giriniz(0-100): ");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci notu giriniz(0-100): ");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü notu giriniz(0-100): ");
            int not3 = Convert.ToInt32(Console.ReadLine());

            double ortalama = ((double)not1 + (double)not2 + (double)not3) / 3.0;
            
            bool kontrol = (ortalama >= 70 && not1 >= 50 && not2 >= 50 && not3 >= 50);

            string sonuc = (kontrol ? "Teşekkür belgesi alabilir":"Teşekkür belgesi alamaz"); 
            Console.WriteLine(sonuc);

            Console.ReadKey();



        }
    }
}
