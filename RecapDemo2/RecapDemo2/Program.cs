using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger();
            //customerManager.Logger = new SmsLogger();
            //customerManager.Logger = new DatabaseLogger();
            customerManager.Add();
            Console.ReadKey();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }
    
    interface ILogger
    {
        void Log();
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }
    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");

        }
    }
    class SmsLogger : ILogger {
        public void Log()
        {
            Console.WriteLine("Logged to SMS!");
        }
    }

}
