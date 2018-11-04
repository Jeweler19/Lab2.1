using System;
using System.Threading;

namespace ConsoleApp1
{
    class Unit3
    {
        public void three()
        {
            Thread mythread = new Thread(pot);
            mythread.Start();
            for (int k = 0; k < 6; k++)
            {
                Console.Clear();
                Thread.Sleep(1000);
            } 
        }
        void pot()
        {
            Unit1 unit1 = new Unit1();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Вся память {0}", unit1.TotalMemory() / 1024);
                Console.WriteLine("Свободная память {0}", unit1.BusyMemory() / 1024);
                Console.WriteLine("Занятая память память {0}", (unit1.TotalMemory() - unit1.BusyMemory()) / 1024);
                Thread.Sleep(1000);
            }
        }
    }
}
