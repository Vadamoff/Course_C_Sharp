//Задача 1:
//Напишите программу замена элементов массива:
//положительные элементы
//замените на соответствующие отрицательные,
//и наоборот.

int[] CreateArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void InvertSymbol(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = - arr[i];
    }
}

void PrintArray(int[] arr)
{
    int leng = arr.Length;
    for(int i = 0; i < leng; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] array = CreateArray(12, -9, 10);

PrintArray(array);

InvertSymbol(array);

PrintArray(array);