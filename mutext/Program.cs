//Nika Shahbeyk_Mutext_400213013_Shiraz University Of Technology
using System;
using System.Threading;

class Program
{
        static Mutex mutext = new Mutex();
        static void Main(String[] args)
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
            mutext.WaitOne();
            Console.WriteLine("Thread number" + obj.ToString(), Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            mutext.ReleaseMutex();
        }
}

