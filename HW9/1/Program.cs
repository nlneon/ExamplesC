// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int[] arrayNumber = new int[numberN];


int[] GetArrayNumber(int numberN, int[] arrayNumber)
{  
    for (int i = 0; i < arrayNumber.Length; i++)
    {
    arrayNumber[i] = numberN;
    numberN--;
    }

    return arrayNumber;
}

void PrintArrayNumber(int[] arrayNumber, int numberN)
{
    Console.Write($"N = {numberN} -> \" ");

    for (int i = 0; i < arrayNumber.Length; i++)
    {
        if (arrayNumber.Length -1 == i) Console.Write($"{arrayNumber[i]} ");
        else Console.Write($"{arrayNumber[i]}, ");
    }

    Console.WriteLine("\"");
}

arrayNumber = GetArrayNumber(numberN, arrayNumber);

PrintArrayNumber(arrayNumber, numberN);