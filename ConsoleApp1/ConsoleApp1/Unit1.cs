using System;

namespace ConsoleApp1
{
    class Unit1
    {
        public void one()
        {
            
            Console.WriteLine("Задание 1:\nПолучить информацию о занятой и свободной память компьютера.");
            Console.WriteLine("Вся память {0}",TotalMemory() / 1024);
            Console.WriteLine("Свободная память {0}", BusyMemory()/1024);
            Console.WriteLine("Занятая память память {0}", (TotalMemory()- BusyMemory())/1024);
            Console.ReadKey();
        }
        public float TotalMemory()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }
        public float BusyMemory()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory;
        }
    }
}
