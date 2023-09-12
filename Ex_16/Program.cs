ulong seed = 1;
ulong res = 0;

for (int i = 1; i <= 64; i++)
{
    res += seed;
    seed *= 2;
}
Console.WriteLine(res);