// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[5];

int sum = 0;
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 101);
    // if (i % 2 ==0) - решение одним циклом с if
    // {
    //     sum += array[i];
    // }
}

for (int i = 0; i < array.Length; i += 2) // - двумя циклами без if
{
   sum += array[i];
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Сумма чисел нечётных позиций массива: {sum}");