using System;

double e = 0.0001;
double s = 1;
double x = 0.5;

for (int i = 2; Math.Pow(x, i - 2) >= e; i += 2)
{
    s += Math.Pow(x, i);
}
Console.WriteLine(s);