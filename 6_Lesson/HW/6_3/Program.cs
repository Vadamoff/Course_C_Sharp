//Задача 3:
//Напишите программу,
//которая будет создавать копию заданного массива
//(вещественные числа) с помощью поэлементного копирования.

double[] CreateArray()
{
    Console.WriteLine("Задайте количество элементов в массиве:");
    int size = int.Parse(Console.ReadLine());
    
    double[] arr = new double[size];

    for(int i = 0; i < size; i++)
        arr[i] = Math.Round(new Random().NextDouble() * (10 + 10) - 10, 2);
    
    return arr;
}

void PrintArray(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] DuplicateArray(double[] arr)
{
    double[] new_arr = new double[arr.Length];
    for(int i = 0; i < arr.Length; i++)
        new_arr[i] = arr[i];
    
    return new_arr;
}

double[] array = CreateArray();

PrintArray(array);

Console.WriteLine("Копия массива:");
PrintArray(DuplicateArray(array));