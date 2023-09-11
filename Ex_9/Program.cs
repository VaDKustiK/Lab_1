using System;

double s = 0;
for (int i = 1; i <= 6; i++)
{
    // Вычисление факториала
    double f = 1;
    for (int j = 1; j <= i; j++)
    {
        f *= j;
    }
    s += Math.Pow(-5, i) / f;
}
Console.WriteLine(s);