using System;

namespace xoxOyunu
{
    class xoxOyun
    {
        char[] boxs = new char[9];

        public xoxOyun()
        {
            for (int i = 0; i < 9; i++)
            {
                boxs[i] = ' ';
            }
        }

        public void tabloGetir()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write(boxs[i - 1]);
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("|");
                }
            }
        }

        public void TabloDoldur(char oyuncu)
        {
            short indis;
            bool geçersizGiris = false;

            while (!geçersizGiris)
            {
                Console.WriteLine($"{oyuncu} için konumu girin (1-9): ");
                indis = Convert.ToInt16(Console.ReadLine());

                if (indis < 1 || indis > 9)
                {
                    Console.WriteLine("Geçersiz konum. Tekrar deneyin.");
                }
                else if (boxs[indis - 1] != ' ')
                {
                    Console.WriteLine("Konum zaten dolu. Tekrar deneyin.");
                }
                else
                {
                    boxs[indis - 1] = oyuncu;
                    geçersizGiris = true;
                }
            }
        }

        public void BilgisayarHaraketi()
        {
            Random rnd = new Random();
            int indis = rnd.Next(0, 9);

            while (boxs[indis] != ' ')
            {
                indis = rnd.Next(0, 9);
            }
            boxs[indis] = 'O';
        }

        public bool bittiMi(char oyuncu)
        {
            if ((boxs[0] == oyuncu && boxs[1] == oyuncu && boxs[2] == oyuncu) ||
                (boxs[0] == oyuncu && boxs[3] == oyuncu && boxs[6] == oyuncu) ||
                (boxs[0] == oyuncu && boxs[4] == oyuncu && boxs[8] == oyuncu) ||
                (boxs[1] == oyuncu && boxs[4] == oyuncu && boxs[7] == oyuncu) ||
                (boxs[2] == oyuncu && boxs[4] == oyuncu && boxs[6] == oyuncu) ||
                (boxs[2] == oyuncu && boxs[5] == oyuncu && boxs[8] == oyuncu) ||
                (boxs[3] == oyuncu && boxs[4] == oyuncu && boxs[5] == oyuncu) ||
                (boxs[6] == oyuncu && boxs[7] == oyuncu && boxs[8] == oyuncu))
            {
                return true;
            }
            return false;
        }

        public bool BosAlanVarMi()
        {
            foreach (var box in boxs)
            {
                if (box == ' ')
                {
                    return true;
                }
            }
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            xoxOyun oyun = new xoxOyun();

            while (true)
            {
                oyun.tabloGetir();

                oyun.TabloDoldur('X');

                if (oyun.bittiMi('X'))
                {
                    oyun.tabloGetir();
                    Console.WriteLine("Kazandınız!");
                    break;
                }

                if (!oyun.BosAlanVarMi())
                {
                    oyun.tabloGetir();
                    Console.WriteLine("Berabere!");
                    break;
                }

                oyun.BilgisayarHaraketi();

                if (oyun.bittiMi('O'))
                {
                    oyun.tabloGetir();
                    Console.WriteLine("Bilgisayar Kazandı!");
                    break;
                }
            }

            Console.WriteLine("...");
            Console.ReadLine();
        }
    }
}
