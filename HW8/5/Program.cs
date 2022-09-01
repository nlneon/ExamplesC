// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

const int ROW = 4;
const int COLUMN = 4;

int[,] BaseArray(int a, int b) 
{
    int[,] newArray = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newArray[i, j] = 0;

    return newArray;
}

const int FIRST_NUM = 10; 

int[,] SpirallArray(int[,] array)
{
    int first = FIRST_NUM; 
    int last = first + array.GetLength(0) * array.GetLength(1) - 1;
    int tempRow = 0; 
    int tempCol = 0; 

    while (first <= last)
    {
        while (tempCol < array.GetLength(1) && array[tempRow, tempCol] == 0)
            array[tempRow, tempCol++] = first++; 
        tempRow++; 
        tempCol--; 

        while (tempRow < array.GetLength(0) && array[tempRow, tempCol] == 0)
            array[tempRow++, tempCol] = first++;
        tempCol--;
        tempRow--;

        while (tempCol >= 0 && array[tempRow, tempCol] == 0)
            array[tempRow, tempCol--] = first++;
        tempRow--;
        tempCol++;

        while (tempRow >= 0 && array[tempRow, tempCol] == 0)
            array[tempRow--, tempCol] = first++;
        tempRow++;
        tempCol++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

// int m = new Random().Next(3, 11);
// int n = new Random().Next(3, 11);

int[,] array = SpirallArray(BaseArray(ROW, COLUMN));

PrintArray(array);