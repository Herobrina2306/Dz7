// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Введите количество строк:");
Console.Write("m = ");
int rews = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Введите количество столбцов:");
Console.Write("n = ");
int com = int.Parse(Console.ReadLine() ?? string.Empty);

double[,] array = GetRandomArray(rews, com, -9, 9);
PrintArray(array);

double[,] GetRandomArray(int m, int n, int min, int max)
{
    double[,] result = new double [m,n];
    double[,] prom = new double [m,n];
    for(int i = 0; i <m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            prom [i,j] = new Random().Next(min,max+1);
            result[i,j] = new Random().NextDouble() + prom[i,j];
        }
    }

    return result;
}

void PrintArray (double[,] newArray)
{
    for(int i = 0; i <newArray.GetLength(0); i++)
    {
        for(int j = 0; j<newArray.GetLength(1); j++)
        {
            string result = string.Format("{0:f1}", newArray[i,j]);
            Console.Write($"{(result)} ");
        }
        Console.WriteLine();
    }
}