int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max)
    {
        max = arg2;
    }
    if (arg3 > max)
    {
        max = arg3;
    }
    return max;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 142, b2 = 23, c2 = 33;
int a3 = 13, b3 =23, c3 = 33;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int unrealMax = Max(max1, max2, max3);

int unrealMax2 = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine($"Максимальное число: {unrealMax}");
Console.WriteLine($"Максимальное число: {unrealMax2}");

int max = a1;
if (b1 > max)
{
    max = b1;
}
if (c1 > max)
{
    max = c1;
}
if (a2 > max)
{
    max = a2;
}
if (b2 > max)
{
    max = b2;
}
if (c2 > max)
{
    max = c2;
}
if (a3 > max)
{
    max = a3;
}
if (b3 > max)
{
    max = b3;
}
if (c3 > max)
{
    max = c3;
}

Console.WriteLine($"Максимальное число: {max}");