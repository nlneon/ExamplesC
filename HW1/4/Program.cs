Console.WriteLine("Введите  число");
int NumberA = Convert.ToInt32(Console.ReadLine());
int n = 2;

if (NumberA < 2)
{
    Console.Write("Введите число >= 2");
}

while (n <= NumberA)
{
    Console.Write(n + " ");
    n = n + 2;
}