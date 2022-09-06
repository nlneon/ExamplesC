// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumMtoN(int M, int N)
{
    if (M < N)
    {
        while (M != N)
            return M + SumMtoN(M + 1, N);
    }

    if (M > N)
    {
        while (M != N)
            return M + SumMtoN(M - 1, N);
    }

    return M;
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма натуральных элементов в указанном промежутке: " + SumMtoN(m, n));