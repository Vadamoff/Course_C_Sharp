//Задача 4. **
//Задайте двумерный массив из целых чисел.
//Напишите программу,
//которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.
//Результат записать в новый массив и вывести

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

int[] FindMin(int[,] arr)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int min = arr[0, 0];
    int[] cellCoord = new int[2];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            if(arr[i, j] < min)
            {
                min = arr[i, j];
                cellCoord[0] = i;
                cellCoord[1] = j;
            }
        }
    }

    return cellCoord;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[,] DeleteRowColArray(int[,] arr, int[] cellCoord)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int k = 0;
    int l= 0;
    int[,] newArr = new int[row - 1, col - 1];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            if(cellCoord[0] != i && cellCoord[1] != j)
            {
                newArr[k, l] = arr[i, j];
                l++;
            }
        }
        l = 0;
        if(cellCoord[0] != i)
            k++;
    }

    return newArr;
}

int[,] array = CreateArray2D();

Console.WriteLine();

Console.WriteLine("Матрица:");
PrintArray2D(array);

int[] minCell = FindMin(array);

Console.WriteLine("Координаты первого наименьшего элемента:");
PrintArray(minCell);

Console.WriteLine();

int[,] newArray = DeleteRowColArray(array, minCell);

Console.WriteLine("Матрица без строки и столбца содержащих первый наименьший элемент:");
PrintArray2D(newArray);