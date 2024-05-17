//Nika Shahbeyk_400213013_LOCK_Shiraz University Of technology
using System;
using System.Threading;

class Program
{
        static object lock2 = new object();
        static void Main()
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
            lock (lock2)
            {
                Console.WriteLine("Thread number" + obj.ToString() , Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(2000);
            }
        }
}


