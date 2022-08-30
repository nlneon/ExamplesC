// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

void FindElement(int[,] arr)
{
    Console.WriteLine("Введите позицию элемента по строке");
    int m = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine("Введите позицию элемента по столбцу");
    int n = Convert.ToInt32(Console.ReadLine()) - 1;
    if ((m < 0 || m >= arr.GetLength(0)) || (n < 0 || n >= arr.GetLength(1)))
    {
        Console.WriteLine("Элемента с введенной позицией нет в массиве");
    }
    else
    {
        Console.WriteLine(arr[m, n]);
    }
}

int[,] array = CreateMatrix(4, 4, 1, 10);
PrintMatrix(array);
Console.WriteLine();
FindElement(array);