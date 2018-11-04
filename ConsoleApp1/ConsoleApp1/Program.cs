using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool z = true;
            int n=0;

            do
            {
                Console.WriteLine("Выберете задание от 1 до 3\nВыход на 4");
                n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Unit1 unit1 = new Unit1();
                            unit1.one();
                            break;
                        case 2:
                            Unit2 unit2 = new Unit2();
                            unit2.two();
                        break;
                        case 3:
                        Unit3 unit3 = new Unit3();
                        unit3.three();
                        break;
                        case 4:
                            Console.WriteLine("До новых встреч.");
                            z = false;
                        break;
                }
            } while (z != false);
            Console.ReadKey();
        }
    }
}
