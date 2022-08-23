﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Число >= 1");
}
else
{
    for (int i = 1; i <= N; i++)
    {
        double CubeN = Math.Pow(i, 3);
        Console.Write($"{CubeN} ");
    }
}