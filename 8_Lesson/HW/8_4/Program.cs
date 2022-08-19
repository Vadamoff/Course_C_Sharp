//Задача 3. *
//Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том,
//сколько раз встречается элемент входных данных.
//Значения элементов массива 0..9

int[,] CreateArray2D()
{
    Console.WriteLine("Задайте количество строк в массиве:");
    int row = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте количество столбцов в массиве:");
    int col = int.Parse(Console.ReadLine());

    int[,] arr = new int[row, col];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(0, 10);
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

int[] FreqDict(int[,] arr)
{
    int[] freqArr = new int[10];

    foreach(int item in arr)
        freqArr[item] += 1;
    
    return freqArr;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i}: {arr[i]} раз");
    Console.WriteLine();
}

int[,] array = CreateArray2D();

Console.WriteLine();

Console.WriteLine("Матрица:");
PrintArray2D(array);

Console.WriteLine();

Console.WriteLine("Частота вхождений значений элементов в матрице:");
PrintArray(FreqDict(array));