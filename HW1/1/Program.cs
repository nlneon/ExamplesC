Console.WriteLine("Введите первое число");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA > NumberB)
{
    Console.WriteLine("Число " + NumberA + " больше " + NumberB);
}
else
{
    Console.WriteLine("Число " + NumberB + " больше " + NumberA);
}