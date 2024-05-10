using System;
using System.Threading;

namespace orneka1
{
    class Program
    { 
        // havalı "Hello World yazdırma B)
        static void Main(string[] args)
        {
            string str = "Hello World";

            for (int i = 0; i < str.Length-1; i++)
            {
                for (int j = 0; j <= (int)str[i]; j++)
                {
                    Console.Write(str.Substring(0, i + 1));
                    Console.Write((char)j);
                    Console.WriteLine();
                    if ((int)str[i] == 108 && (char)j == 'd')
                    {
                        break;
                    }
                }
                Thread.Sleep(10);
            }
            Console.ReadKey();
        }
    }
}
