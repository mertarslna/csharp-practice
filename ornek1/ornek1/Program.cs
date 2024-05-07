using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        { // Bu program, kullanıcıdan bir cümle alacak ve cümlenin içinde kaç tane sesli harf bulunduğunu hesaplayacak.
          // Türkçe'de kullanılan sesli harfler: a, e, ı, i, o, ö, u, ü. Program, kullanıcıya sonuç olarak sesli harf sayısını ekrana yazdıracak.
            int sesliSayisi = 0; // başlangıçta sesli olmadığı için 0 aldım
            String cumle = Console.ReadLine();

            for (int i = 0; i < cumle.Length; i++) //cümleyi baştan sonra her harfi geziyor
            {
                if (cumle[i] == 'a' || cumle[i] == 'e' || cumle[i] == 'ı' || cumle[i] == 'i' ||
                    cumle[i] == 'o' || cumle[i] == 'ö' || cumle[i] == 'u' || cumle[i] == 'ü') //sesli harf kontolü
                {
                    sesliSayisi++; // sesli sayısı artırıyor
                }
            }
            Console.WriteLine(sesliSayisi);
            Console.ReadKey();
        }

    }
}
