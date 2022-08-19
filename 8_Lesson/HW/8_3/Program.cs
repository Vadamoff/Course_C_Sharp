//Задача 3:
//Задайте две матрицы.
//Напишите программу,
//которая будет находить произведение двух матриц.

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

void CreateMultiArray2D(int[,] arr1, int[,] arr2)
{
    int row1 = arr1.GetLength(0);
    int col1 = arr1.GetLength(1);
    int row2 = arr2.GetLength(0);
    int col2 = arr2.GetLength(1);

    int[,] multArr = new int[row1, col2];

    if(col1 != row2)
        Console.WriteLine("Данные матрицы умножить нельзя");
    else
    {
        int sum;

        for(int i = 0; i < row1; i++)
        {
            for(int j = 0; j < col2; j++)
            {
                sum = 0;
                
                for(int k = 0; k < col1; k++)
                {
                    sum += arr1[i, k] * arr2[k, j];
                }
                
                multArr[i, j] = sum;
            }
        }

        Console.WriteLine("Произведение двух матриц:");
        PrintArray2D(multArr);
    }
}

int[,] array1 = CreateArray2D();

Console.WriteLine();

Console.WriteLine("Первая матрица матриц:");
PrintArray2D(array1);

Console.WriteLine();

int[,] array2 = CreateArray2D();

Console.WriteLine();

Console.WriteLine("Вторая матрица:");
PrintArray2D(array2);

CreateMultiArray2D(array1, array2);