using System;
{
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        double t = -6;

        double a = Math.Log10(x);
        double b = Math.Sqrt(x * x + t * t);
        double y = Math.Pow(Math.Abs(a - b * x), 1.0 / 5);
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"y = {y}");
        Console.ReadKey();
}