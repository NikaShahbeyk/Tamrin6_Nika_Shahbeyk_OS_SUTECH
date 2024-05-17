//Nika Shahbeyk_400213013_monitor_Shiraz University Of Technology
using System;
using System.Collections.Generic;
class Program
{
        static object m = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(withdrawMoney);
                thread.Start(i+1);
            }
            Console.ReadKey();
        }
        static void withdrawMoney(object obj)
        {
            Monitor.Enter(m);
            Console.WriteLine("Thread number " + obj.ToString());
            Thread.Sleep(1000);
            Monitor.Exit(m);
          
        }
}
