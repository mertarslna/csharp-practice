using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    // void döndüren ve parametre almayan operasyonlara delegelik yapar
    public delegate void MyDelegate2(string text);
    // void döndüren ve parametre alan operasyonlara delegelik yapar
    public delegate int MyDelegate3(int num1,int num2);
    // int döndüren ve parametre alan operasyonlara delegelik yapar
    public delegate int MyDelegate4();
    // int döndüren ve parametre almayan operasyonlara delegelik yapar
    
    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessage2(string text)
        {
            Console.WriteLine(text);
        }
        public void ShowAlert2(string text)
        {
            Console.WriteLine(text);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Matematik matematik = new Matematik();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate;

            myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;

            MyDelegate2 myDelegate2;

            myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            MyDelegate3 myDelegate3;

            myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            // delegelerde return type varsa son yapılan için kullanılır

            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);

            Console.WriteLine();

            myDelegate2("Hello!");
            // delegeyi aynı parametreyle gönderme kısıtı mevcut

            Console.WriteLine();

            myDelegate();

            Console.ReadLine();
        }
    }
}
