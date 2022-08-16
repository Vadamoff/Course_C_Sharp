//Задача 3:
//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray2D()
{
    Console.WriteLine("Задайте количество строк в массиве:");
    int row = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте количество столбцов в массиве:");
    int col = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте начало диапазона случайных чисел для элементов в массиве:");
    int from = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте конец диапазона случайных чисел для элементов в массиве:");
    int to = int.Parse(Console.ReadLine());

    int[,] arr = new int[row, col];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(from, to + 1);
        }
    }
    
    return arr;
}

void PrintArray2D(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ColAverage(int[,] arr)
{
    double sum;

    for(int i = 0; i < arr.GetLength(1); i++)
    {
        sum = 0;

        for(int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }

        Console.WriteLine($"Среднее арифметическое {i + 1} столбца: {Math.Round((sum / arr.GetLength(1)), 2)}");
    }
}

int[,] array = CreateArray2D();

Console.WriteLine();

Console.WriteLine("Массив:");
PrintArray2D(array);

ColAverage(array);