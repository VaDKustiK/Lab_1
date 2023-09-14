using System;
using System.Text;

double a = 0.1;
double b = 1;
double h = 0.1;
double stop = 0.0001;
double s = 0;
double e = Double.Epsilon;

for (double x = a; x <= b; x += h)
{
    double last = 1;
    s = 0;
    for (int i = 1; Math.Abs(last) >= stop; i++)
    {
        // factorial
        double f = 1;
        for (int j = 1; j <= i; j++)
        {
            f *= j;
        }

        last = Math.Cos(i * x) / f;
        s += last;
    }
    Console.WriteLine($"X = {x.ToString("0.0")}, S = {1 + s}, y = {Math.Pow(e, Math.Cos(x)) * Math.Cos(Math.Sin(x))}");
}