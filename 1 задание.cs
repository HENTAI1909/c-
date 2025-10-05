using System;
double w = 25;
double y = 13;
double G = (9.33 * Math.Pow(w, 3) + Math.Sqrt(w)) / (Math.Log(y + 3.5) + Math.Sqrt(y));
Console.WriteLine($"G = {G}");
Console.ReadKey();
