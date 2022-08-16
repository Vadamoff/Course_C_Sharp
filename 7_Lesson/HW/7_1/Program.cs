//Задача 1:
//Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

double[,] CreateArray2D()
{
    Console.WriteLine("Задайте количество строк в массиве:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте количество столбцов в массиве:");
    int n = int.Parse(Console.ReadLine());

    double[,] arr = new double[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * (10 + 10) - 10, 2);
        }
    }
    
    return arr;
}

void PrintArray2D(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 6} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] array = CreateArray2D();

PrintArray2D(array);