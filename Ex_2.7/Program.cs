using System;
using System.Text;

double x1 = 0;
double s1 = 10;

// 8 (A)
int n1 = 0;

while (n1 <= 7)
{
    n1 += 1;
    x1 += s1;
    s1 *= 1.1;
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine($"Ответ на пункт А: {x1}");

//8 (Б)
double s2 = 10;
double c2 = 0;
int n2 = 0;

while (c2 < 100)
{
    n2++;
    c2 += s2;
    s2 *= 1.1;
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine($"Ответ на пункт Б: {n2}");

// 8 (В)
double s3 = 10;
int n3 = 0;

while (s3 <= 20)
{
    n3++;
    s3 *= 1.1;
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine($"Ответ на пункт В: {n3}");