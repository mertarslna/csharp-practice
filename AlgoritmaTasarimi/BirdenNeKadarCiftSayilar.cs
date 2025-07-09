using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    internal class BirdenNeKadarCiftSayilar
    {
        public static int Find(int n)
        {
            n = n / 2;
            return n * (n + 1); //0 2 4 6 8 10 12 14 16 18..
        }
    }
}
