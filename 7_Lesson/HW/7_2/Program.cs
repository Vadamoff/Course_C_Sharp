//Задача 2:
//Напишите программу,
//которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание,
//что такого элемента нет.

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

void FindElement(int[,] arr)
{
    Console.WriteLine("Введите номер строки:");
    int row = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int col = int.Parse(Console.ReadLine());

    Console.WriteLine();
    
    if(row > arr.GetLength(0) || col > arr.GetLength(1))
        Console.WriteLine("Такого элемента нет");
    else
        Console.WriteLine($"На этих позициях находится элемент со значением {arr[row - 1, col - 1]}");
}

int[,] array = CreateArray2D();

Console.WriteLine();

FindElement(array);

Console.WriteLine();

PrintArray2D(array);