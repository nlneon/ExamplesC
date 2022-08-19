// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 | a > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else if (a >= 1 & a <= 5)
{
    Console.WriteLine("нет");
}
else if (a == 6 | a == 7)
{
    Console.WriteLine("да");
}