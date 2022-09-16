//Задача 3:
//Задайте массив вещественных чисел.
//Найдите разницу между максимальным
//и минимальным элементами массива.

double[] CreateArray()
{
    Console.WriteLine("Задайте количество элементов в массиве:");
    int size = int.Parse(Console.ReadLine());

    double[] arr = new double[size];

    for(int i = 0; i < size; i++)
        arr[i] = new Random().NextDouble();
    
    return arr;
}

void PrintArray(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double FindMaxInArray(double[] arr)
{
    int i = 0;
    double max = arr[i];
    for(i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
            max = arr[i];
    }
    return max;
}

double FindMinInArray(double[] arr)
{
    int i = 0;
    double min = arr[i];
    for(i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
            min = arr[i];
    }
    return min;
}

double[] array = CreateArray();

PrintArray(array);

Console.WriteLine("Разница между максимальным и минимальным элементами массива:");
Console.WriteLine(FindMaxInArray(array) - FindMinInArray(array));