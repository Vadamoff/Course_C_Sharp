//Задача 3:
//Задайте двумерный массив.
//Найдите сумму элементов главной диагонали.

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

int SumMainDiagonalElements(int[,] arr)
{
    int sum = 0;
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);

    if(row < col)
        col = row;
    else if(row > col)
        row = col;

    for(int i = 0; i < row; i++)
    {
        sum += arr[i, i];
    }
    
    return sum;
}

int[,] array = CreateArray2D();

PrintArray2D(array);

Console.WriteLine(SumMainDiagonalElements(array));