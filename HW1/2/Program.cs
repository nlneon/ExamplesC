Console.WriteLine("Введите первое число");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int NumberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int NumberC = Convert.ToInt32(Console.ReadLine());

if (NumberA > NumberB & NumberA > NumberC)
{
    Console.WriteLine("Наибольшее число: " + NumberA);
}
else if (NumberB > NumberA & NumberB > NumberC)
{
    Console.WriteLine("Наибольшее число: " + NumberB);
}
else
{
    Console.WriteLine("Наибольшее число: " + NumberC);
}