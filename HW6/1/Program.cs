// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число элементов массива:");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} число массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        count += 1;
    }
}

Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Чисел больше 0 в массиве: {count}");