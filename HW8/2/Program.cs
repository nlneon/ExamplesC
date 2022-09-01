// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindSum(int[,] array)
{
    int[] sumArr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumArr[i] = sum;
    }
    return sumArr;
}

void PrintArraySum(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Сумма эллементов {i} строки = {array[i]}\t");
    }
}

void FindMinRow(int[] sumArr)
{
    int minRow = 0;
    int min = sumArr[0];
    for (int i = 0; i < sumArr.GetLength(0); i++)
    {
        if (min > sumArr[i])
        {
            min = sumArr[i];
            minRow = i;
        }
    }
    Console.WriteLine($"Строка {minRow+1} имеет наименьшую  сумму  эллементов");
}

int[,] array = CreateMatrix(4, 4, 1, 10);
PrintMatrix(array);
Console.WriteLine();
int[] sumArr = FindSum(array);
PrintArraySum(sumArr);
Console.WriteLine();
FindMinRow(sumArr);