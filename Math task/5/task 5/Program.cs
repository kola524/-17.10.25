using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double a = Math.PI / 6; 
            double b = Math.PI / 4; 
            double R = 10.0;        
            double T = 2.0;       

            // Формула Y
            double numeratorY = Math.Sin(a) + Math.Cos(2 * b + a) - 1;
            double denominatorY = Math.Cos(a) - Math.Cos(2 * b + a);
            double Y = numeratorY / denominatorY;

            // Формула X
            double numeratorX = R - 4;
            double denominatorX = R + 4 * T;
            double X = Math.Sqrt(numeratorX / denominatorX);

            // Вывод результатов
            Console.WriteLine($"Y = {Y}");
            Console.WriteLine($"X = {X}");
        }
    }
}
