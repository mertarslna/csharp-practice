using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Ders notu 50-100 arasında ise geçti, değilse kaldı bilgisini yazdırınız.
            // (if kullanmadan)2

            int dersNotu;
            Console.Write("Ders notunuzu giriniz(0-100):");
            dersNotu = Convert.ToInt32(Console.ReadLine());

            bool gectiMi = (dersNotu >= 50 && dersNotu <= 100);
            string sonuc2 = (gectiMi ? "geçti" : "kaldı");

            Console.Write(sonuc2);

            Console.ReadKey();  
        }
    }
}
