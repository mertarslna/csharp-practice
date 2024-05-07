using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İşe girmek için en az lisans ya da önlisans mezunu olma durumunu kontrol ediniz.
            Console.Write("Egitim Durumu:");
            string egitim = Console.ReadLine();

            string sonuc = (egitim == "lisans" || egitim == "önlisans" ? "İşe girebilir.":"İşe giremez");
            Console.WriteLine(sonuc);

            Console.ReadKey();  
        }
    }
}
