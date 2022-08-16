//Задача 4:
//Задайте двумерный массив.
//Введите элемент,
//и найдите первое его вхождение,
//выведите позиции по горизонтали и вертикали,
//или напишите, что такого элемента нет.

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

string FindElement(int[,] arr)
{
    Console.WriteLine("Введите число:");
    int num = int.Parse(Console.ReadLine());
    
    Console.WriteLine();
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] == num)
                return $"Элемент находится в {i + 1} строке {j + 1} столбце";
        }
    }

    return "Такого элемента нет";
}

int[,] array = CreateArray2D();

Console.WriteLine();

Console.WriteLine(FindElement(array));

Console.WriteLine();

PrintArray2D(array);