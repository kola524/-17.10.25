using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            double R = 4.0;
            double T = 2.0; 
            double a = Math.PI / 6; 

            // Формула Y
            double numeratorY = Math.Sqrt(R + 3 * Math.Sqrt(Math.Pow(T, 3)) - 3);
            double denominatorY = Math.Sqrt(Math.Pow(T, 2) - 3 + Math.Sqrt(R));
            double Y = numeratorY / denominatorY;

            // Формула X
            double X = Math.Tan((3 * Math.PI / 2) - a) + 0.5;

            // Вывод результатов
            Console.WriteLine($"Y = {Y}");
            Console.WriteLine($"X = {X}");

        }
    }
}
