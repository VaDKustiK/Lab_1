int chisl_1 = 1;
int chisl_2 = 2;
int znam_1 = 1;
int znam_2 = 1;

int chisl;
int znam;

double res = 0;

for (int i = 0; i <= 5; i++)
{
    chisl = chisl_2 + chisl_1;
    znam = znam_2 + znam_1;

    chisl_1 = chisl_2;
    znam_1 = znam_2;
    chisl_2 = chisl;
    znam_2 = znam;

    res = (double) chisl / znam;
}
Console.WriteLine(res);