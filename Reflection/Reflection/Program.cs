using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            //Console.WriteLine(dortIslem.Topla2(3,4));
            
            var tip = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            //DortIslem dortIslem = new DortIslem(2,3);
            //Çalışma anında gelen tipe göre gerçekleştirme
            //Console.WriteLine(dortIslem.Topla(3, 4));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(tip, 6, 7);
            MethodInfo metodBilgisi = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(metodBilgisi.Invoke(instance,null));

            var metodlar = tip.GetMethods();

            foreach (var metod in metodlar)
            {
                Console.WriteLine("Metod adı : {0} ",metod.Name);
                foreach (var parametre in metod.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}",parametre.Name);
                }
                foreach (var attribute in metod.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}",attribute.GetType().Name);
                }
                Console.WriteLine();
            }
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
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        [MetodName("ParametresizTopla")]
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetodName("ParametresizCarp")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }
    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
