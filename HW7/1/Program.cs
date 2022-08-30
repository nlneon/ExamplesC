﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int RANDOM1 = 8;
int RANDOM2 = 3;

double [,] CreateMatrix(int rowCount, int columnCount)
{
    double [,] array = new double [rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().NextDouble()*RANDOM1-RANDOM2;
        }
    }
    return array;
}

void PrintMatrix(double[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]:f1}\t");
        }
        Console.WriteLine();
    }
}
double [,] array = CreateMatrix(3, 4);
PrintMatrix(array);