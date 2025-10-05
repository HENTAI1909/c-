using System;
{
    Console.Write("введите трехзнач число");
    int n=int.Parse(Console.ReadLine());
        int result = (n % 100) * 10 + n / 100;
        Console.WriteLine(result);
}
