// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] Multiplication(int[,] arrayA, int[,] arrayB)
{
    if (arrayA.GetLength(1) != arrayB.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзя перемножить");
    }
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int rowsA = 0; rowsA < arrayA.GetLength(0); rowsA++)
    {
        for (int columnsB = 0; columnsB < arrayB.GetLength(1); columnsB++)
        {
            for (int rowsB = 0; rowsB < arrayB.GetLength(0); rowsB++)
            {
                arrayC[rowsA, columnsB] += arrayA[rowsA, rowsB] * arrayB[rowsB, columnsB];
            }
        }
    }
    return arrayC;
}

int[,] arrayA = CreateMatrix(2, 2, 1, 10);
int[,] arrayB = CreateMatrix(2, 2, 1, 10);
Console.WriteLine("Матрица А:");
PrintMatrix(arrayA);
Console.WriteLine();
Console.WriteLine("Матрица B:");
PrintMatrix(arrayB);
Console.WriteLine();
Console.WriteLine("Результат умножения:");
int[,] arrayC = Multiplication(arrayA, arrayB);
PrintMatrix(arrayC);