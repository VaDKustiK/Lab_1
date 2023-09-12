using System;
using System.Text;

int n = 10;

for (int i = 3; i <= 24; i += 3)
{
    n *= 2;
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine($"Через {i} часов будет {n} клеток");
}