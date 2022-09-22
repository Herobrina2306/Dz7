// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine() ?? string.Empty);

int[,] array = GetArray(row, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
Average(array);

int[,] GetArray(int m, int n, int minVaiue, int maxVaiue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(minVaiue, maxVaiue +1);
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

void Average(int[,] arrayNew)
{
    double aver = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < arrayNew.GetLength(1); j++)
    {
        for(int i = 0; i < arrayNew.GetLength(0); i++)
        {
            aver += arrayNew[i,j];
        }
        aver = aver/arrayNew.GetLength(0);
        Console.Write($"{aver}  ");
        aver = 0;
    }
}