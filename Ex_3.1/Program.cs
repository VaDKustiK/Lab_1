using System;
using System.Text;

double a = 0.1;
double b = 1;
double h = 0.1;
double stop = 0.0001;
double s = 0;

for (double x = a; x <= b; x += h)
{
    double last = 1; // 1 > stop
    s = 0;
    for (int i = 0; Math.Abs(last) >= stop; i++)
    {
        // factorial
        double f = 1;
        for (int j = 1; j <= 2 * i; j++)
        {
            f *= j;
        }

        last = Math.Pow(-1, i) * (Math.Pow(x, 2 * i) / f);
        s += last;
        //Console.WriteLine($"X = {x}, i = {i}, f = {f}, last = {last}"); проверка
    }
    Console.WriteLine($"X = {x.ToString("0.0")}, S = {s}, y = {Math.Cos(x)}");
}