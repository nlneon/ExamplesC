int[] array = { 1, 32, 33, 4, 5, 56, 67, 81, 4 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index += 1;
}