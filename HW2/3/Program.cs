﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int a = Convert.ToInt32(Console.ReadLine());

if ((a <= 99 & a >= -99) | a >= 1000 | a <= -1000) // стало интересно ещё отрицательные попробовать добавить :))
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    int b = (a - a/100*100)/10;
    Console.WriteLine(Math.Abs(b));
}