using System;

public class task_1
{
    public static void Main(string[] args)
    {
        double a = Math.PI / 4; // Пример значения для переменной a

        // Вычисление Y
        double Y = Math.Pow(Math.Cos((4 * Math.PI / 7) - a), 2) +
                   Math.Pow(Math.Cos((12 * Math.PI / 7) + (a / 3)), 2);

        // Вычисление X
        double X = (Math.Cos(2 * a) / Math.Sqrt(2 * Math.Sin(a))) + (1 / Math.Tan(2 * a));

        Console.WriteLine($"Y = {Y}");
        Console.WriteLine($"X = {X}");
    }
}