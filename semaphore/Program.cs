//Nika Shahbeyk_400213013_Semaphore_Shiraz University Of Technology
using System;
using System.Threading;


class Program
    {
        static Semaphore sem = new Semaphore(2,2);
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
            sem.WaitOne();
            Console.WriteLine($"Account {obj} is withdrawing money...");
            Thread.Sleep(2000);
            Console.WriteLine($"Account {obj} has withdrawen money...");
            sem.Release();
        }
    }