// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = {3, 7, 22, 2, 78};

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] >= max)
    {
        max = array[i];
    }
    else
    {
        min = array[i];
    }
}

double dif = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {dif}");