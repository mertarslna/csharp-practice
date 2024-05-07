using System;
using System.Xml;

namespace ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu program, kullanıcıya iki tarih arasındaki farkı hesaplayacak. Kullanıcıdan iki tarih
            // alacak ve bu tarihler arasındaki gün, saat ve dakika cinsinden farkı ekrana yazdıracak.
            // DateTime(yıl,ay,gün,saat,dakika,saniye)
            Console.WriteLine("ilk tarih:");
            DateTime dt1 = InputTarih();

            Console.WriteLine("ikinci tarih");
            DateTime dt2 = InputTarih();

            int yilFark = Math.Abs(dt2.Year - dt1.Year);
            int ayFark = Math.Abs(dt2.Month - dt1.Month);
            int gunFark = Math.Abs(dt2.Day - dt1.Day);
            int saatFark = Math.Abs(dt2.Hour - dt1.Hour);
            int dakikaFark = Math.Abs(dt2.Minute - dt1.Minute);
            int saniyeFark = Math.Abs(dt2.Second - dt1.Second);

            Console.WriteLine($"Tarihler arasındaki fark:{yilFark} yil, {ayFark} ay, {gunFark} gün, " +
                $"{saatFark} saat, {dakikaFark} dakika, {saniyeFark} saniye");
            Console.ReadKey();
        }

        static DateTime InputTarih()
        {
            int yil, ay, gun, saat, dakika, saniye;
            
            Console.Write("Yıl: ");
            yil = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ay: ");
            ay = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Gün: ");
            gun = Convert.ToInt32(Console.ReadLine());

            Console.Write("Saat: ");
            saat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dakika: ");
            dakika = Convert.ToInt32(Console.ReadLine());

            Console.Write("Saniye: ");
            saniye = Convert.ToInt32(Console.ReadLine());


            return new DateTime(yil, ay, gun, saat, dakika, saniye);
        }
    }
}
