//Задача 2:
//Задайте прямоугольный двумерный массив.
//Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.

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
            Console.Write($"{arr[i, j], 2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] CreateRowSumArray(int[,] arr)
{
    int[] rowSum = new int[arr.GetLength(0)];

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;

        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }

        rowSum[i] = sum;
    }
    
    return rowSum;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int FindMinInArray(int[] arr)
{
    int i = 0;
    int min = i;
    for(i = 1; i < arr.Length; i++)
    {
        if(arr[i] < arr[min])
            min = i;
    }
    return min;
}

int[,] array = CreateArray2D();

PrintArray2D(array);

Console.WriteLine();

int[] rowSumArr = CreateRowSumArray(array);

PrintArray(rowSumArr);

Console.WriteLine();

Console.WriteLine($"Наименьшая сумма элементов находится на {FindMinInArray(rowSumArr) + 1} строке");