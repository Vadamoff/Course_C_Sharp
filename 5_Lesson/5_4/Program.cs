//Задача 3:
//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива,
//значения которых лежат в отрезке [10, 99].

int[] CreateArray()
{
    Console.WriteLine("Задайте количество элементов в массиве:");
    int size = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте начало диапазона случайных чисел для элементов в массиве:");
    int from = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте конец диапазона случайных чисел для элементов в массиве:");
    int to = int.Parse(Console.ReadLine());

    int[] arr = new int[size];

    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

void FindCountElements(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99)
            count += 1;
    }

    if(count == 0)
        Console.WriteLine($"В массиве нет чисел из заданного диапазона");
    else
        Console.WriteLine($"В массиве {count} чисел из заданного диапазона");
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

int[] array = CreateArray();

PrintArray(array);

FindCountElements(array);