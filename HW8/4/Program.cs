// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array = new int[2, 2, 2];

int[,,] MakeArray(int[,,] array)
{
    int first = 10;
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j,k] = first;
                first++;
            }
        }
    }
    return array;
}

// + реализация рандомного массива с просторов интернета)
static IEnumerable<int> UniqueRandomNumbers(int from, int to)
{
    Random rand = new();
    int[] values = Enumerable.Range(from, to).ToArray();
    int i = values.Length;
    while (i > 0)
    {
        int j = rand.Next(i--);
        yield return values[j];
 
        (values[i], values[j]) = (values[j], values[i]);
    }
}

int[,,] arr = new int[2, 2, 2];
 
IEnumerator<int> iterator = UniqueRandomNumbers(10, 99).GetEnumerator();
 
for (int i = 0; i < arr.GetLength(0); i++)
for (int j = 0; j < arr.GetLength(1); j++)
for (int k = 0; k < arr.GetLength(2); k++)
{
    if (!iterator.MoveNext())
    {
        Console.WriteLine("Упс, уникальные числа закончились!");
        return;
    }
 
    arr[i, j, k] = iterator.Current;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

MakeArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(arr);