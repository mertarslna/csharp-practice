using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    internal class DilimDaireninAlani
    {
        public static double Find(double yariCap,double aci)
        {
            return yariCap * yariCap * Matematik.PI * aci/360;
        }
    }
}
