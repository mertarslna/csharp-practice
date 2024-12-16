using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Topla());
            //Console.WriteLine(dortIslem.Topla(3,4));
            
            var tip = typeof(DortIslem);
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            //DortIslem dortIslem = new DortIslem(2,3);
            //Çalışma anında gelen tipe göre gerçekleştirme
            Console.WriteLine(dortIslem.Topla(3, 4));
            Console.WriteLine(dortIslem.Topla());

            Console.ReadLine();
        }
    }
    public class DortIslem 
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem() { }
        public DortIslem(int sayi1,int sayi2) 
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp()
        {
            return _sayi1 * _sayi2;
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

    }
}
