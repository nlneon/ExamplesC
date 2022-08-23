// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int a = Convert.ToInt32(Console.ReadLine());
int moda = Math.Abs(a);

string NumInStr = Convert.ToString(moda);
    char b = NumInStr[0];
    char c = NumInStr[4];
    char d = NumInStr[1];
    char e = NumInStr[3];

if (moda < 10000 || moda > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else
{
        
    if (b == c && d == e)
    {
        Console.WriteLine("Yes");
    }
    else
    Console.WriteLine("No");
}