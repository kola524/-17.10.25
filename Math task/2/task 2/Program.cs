using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Входные данные
            double R = 2.0; // Пример значения R
            double T = 3.0; // Пример значения T
            double b = Math.PI / 4; // Пример значения b (в радианах)

            // Формула Y
            double numeratorY = (R + 1) * Math.Sqrt(R) - (T + 1) * Math.Sqrt(T);
            double denominatorY = Math.Sqrt(Math.Pow(R, 5) + R * T - Math.Pow(R, 3) - R);
            double Y = numeratorY / denominatorY;

            // Формула X
            double numeratorX = Math.Sin(5 * b) + 1;
            double denominatorX = Math.Cos(5 * b) + 1;
            double X = numeratorX / denominatorX;

            // Вывод результата
            Console.WriteLine($"Y = {Y}");
            Console.WriteLine($"X = {X}");
        }
    }
}
