using System;

double s = 0;
double x = 5;
for (int i = 1; i < 10; i++)
{
    s += Math.Cos(x * i) / Math.Pow(x, i - 1);
}
Console.WriteLine(s);