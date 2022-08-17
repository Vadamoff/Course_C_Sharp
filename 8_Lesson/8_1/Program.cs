//Задача 1:
//Задайте двумерный массив.
//Напишите программу,
//которая поменяет местами первую
//и последнюю строку массива.

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

/*
int[,] ChangeFirstLastRowsArray(int[,] arr)
{
    int temp;
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = temp;
    }

    return arr;
}
*/

void ChangeFirstLastRowsArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        (arr[0, i], arr[arr.GetLength(0) - 1, i]) = (arr[arr.GetLength(0) - 1, i], arr[0, i]);
    }
}

int[,] array = CreateArray2D();

PrintArray2D(array);

Console.WriteLine();

//PrintArray2D(ChangeFirstLastRowsArray(array));

ChangeFirstLastRowsArray(array);

PrintArray2D(array);