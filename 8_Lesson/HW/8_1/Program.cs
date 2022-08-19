//Задача 1:
//Задайте двумерный массив.
//Напишите программу,
//которая упорядочит по убыванию
//элементы каждой строки двумерного массива.

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

int[,] BubbleSort(int[,] arr)
{
    int temp;
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = j + 1; k < arr.GetLength(1); k++)
            {
                if(arr[i, j] < arr[i, k])
                {
                    (arr[i, j], arr[i, k]) = (arr[i, k], arr[i, j]);
                }
            }
        }
    }
    
    return arr;
}

int[,] array = CreateArray2D();

PrintArray2D(array);

Console.WriteLine();

BubbleSort(array);

PrintArray2D(array);