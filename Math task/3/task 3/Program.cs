using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Math.PI / 6; 
            double R = 2.0;         

            // Формула Y
            double numeratorY = Math.Sin(2 * a) + Math.Sin(3 * a) - Math.Sin(4 * a);
            double denominatorY = Math.Cos(2 * a) + 1 + Math.Cos(3 * a);
            double Y = numeratorY / denominatorY;

            // Формула X
            double denominatorX = Math.Sqrt(2 * R + 3);
            double X = 1 / denominatorX;

            // Вывод результатов
            Console.WriteLine($"Y = {Y}");
            Console.WriteLine($"X = {X}");
        }
    }
}
