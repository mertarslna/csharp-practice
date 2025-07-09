using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    internal class AralikliCiftSayilar
    {

        public static int Find(int initial,int final)
        {
            int result;
            result = BirdenNeKadarCiftSayilar.Find(final) - BirdenNeKadarCiftSayilar.Find(initial);
            return result;
        }
    }
}
