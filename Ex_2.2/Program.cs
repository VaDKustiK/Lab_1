int n = 1;
int p = 1;
int L = 30000;

while (p <= L)
{
    n += 3;
    p = p * n;
}
Console.WriteLine(n-3);