// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вводим массив через консоль

int[] array = new int[8];

for (int i = 0; i <= 7; i++)
{
    Console.WriteLine($"Введите {i+1} число массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine(string.Join(", ", array));

// изначально сделал циклом)
// for (int i = 0; i <= 7; i++)
// {
//     Console.Write($"{array[i]} ");
// }