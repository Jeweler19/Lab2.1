using System;
using System.Threading;

namespace ConsoleApp1
{
    class Unit2
    {
        public void two()
        {
            Unit1 unit1 = new Unit1();
            int i = 0,
                n=0;
            Console.WriteLine("Задание 3:\nВывести информацию о памяти циклически с остановками");
            Console.WriteLine("Сколько секунд будем спать?");
                n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Вся память {0}", unit1.TotalMemory() / 1024);
                Console.WriteLine("Свободная память {0}", unit1.BusyMemory() / 1024);
                Console.WriteLine("Занятая память память {0}", (unit1.TotalMemory() - unit1.BusyMemory()) / 1024);
                Thread.Sleep(n*100);
                i++;
            } while (i < 5);
            Console.ReadKey();
        }
        
        
    }
}
