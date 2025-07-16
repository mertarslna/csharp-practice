using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaTasarimi
{
    internal class ASCII
    {
        public static void Print()
        {
            for (int i = 32; i < 126; i++)
            {
                Console.Write("{0,5} : {1} ",i,(char)i);
                if(i % 5 == 0)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
