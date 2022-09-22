// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

Console.Clear();

int row = new Random().Next(4, 10);
int col = new Random().Next(4, 10);

int[,] array = GetRandomArray(row, col, 0, 9);
PrintArray(array);

Console.WriteLine("Введите номер позиции элемента через энтер:");
int order1 = int.Parse(Console.ReadLine() ?? string.Empty);
int order2 = int.Parse(Console.ReadLine() ?? string.Empty);

SequenceNumber(array, order1, order2);

int[,] GetRandomArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(min, max +1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0); i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SequenceNumber(int[,] arrayNew, int a, int b )
{
    if(a > arrayNew.GetLength(0) || b > arrayNew.GetLength(1))
    Console.WriteLine($"[{a}, {b}] - > Такого числа в массиве нет. В массиве всего {arrayNew.GetLength(0)} строк и {arrayNew.GetLength(1)} столбцов.");
    else
    Console.WriteLine($"[{a}, {b}] -> {arrayNew[a,b]} ");
}