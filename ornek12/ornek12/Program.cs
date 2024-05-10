using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = File.OpenText("deneme.txt"); // vs için C:\Users\UserX\source\repos\ornek12\ornek12\bin\Debug default olarak içine atılmalı

            String s = "";
            while ((s = sr.ReadLine()) != null) {
                Console.WriteLine(s); 
            }
            Console.ReadKey();
        }
    }
}   
