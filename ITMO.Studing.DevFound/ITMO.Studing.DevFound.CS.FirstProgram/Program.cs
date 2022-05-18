using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Studing.DevFound.CS.FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "да";
            do
            {
                Console.WriteLine("Введите координату x точки 1");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату у точки 1");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату x точки 2");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату у точки 2");
                int y2 = Convert.ToInt32(Console.ReadLine());
                if (x1 == x2) //сhecking division by zero
                {
                    Console.WriteLine($"x1=x2. Это вертикальная линия с смещением от оси Y на {x1}. Даные введены корректно?(да/нет)");
                    answer = Console.ReadLine();
                }
                else
                {
                    int K = (y1 - y2) / (x1 - x2);
                    int B = y2 - K * x2;
                    Console.WriteLine($"Получены следующие коэффициенты: K={K}, B={B}");
                }
            }
            while (answer == "нет");
            Console.WriteLine("Конец работы программы");
        }
    }
}
