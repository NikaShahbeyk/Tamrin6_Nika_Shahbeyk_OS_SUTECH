//Nika Shahbeyk_400213013_Auto Reset Event_Shiraz University Of Technology
using System;
using System.Threading;

class Program
 {
        static AutoResetEvent a = new AutoResetEvent(true);
        static void Main(String[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(withdrawMoney);
                thread.Start(i + 1);
            }
            Console.ReadKey();
        }
        static void withdrawMoney(object obj)
        {
            a.WaitOne();
            Console.WriteLine("Thread number" + obj.ToString(), Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            a.Set();
        }
 }

