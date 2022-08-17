void FillArray(int[] collectiion)
{
    int lenght = collectiion.Length;
    int index = 0;
    while (index < lenght)
    {
        collectiion[index] = new Random().Next(1,10);
        
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf( int[] cillection, int find)
{
    int count = cillection.Length;
    int index = 0;
    int position = -1; // чтобы понятно было, когда элемента нет
    while (index < count)
    {
        if(cillection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; // массив из 10 чисел, заполненный нулями

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);