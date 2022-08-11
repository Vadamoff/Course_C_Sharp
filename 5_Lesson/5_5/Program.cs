//Задача 4:
//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент,
//второй и предпоследний и т.д.
//Результат запишите в новом массиве.

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

void PrintArray(int[] arr)
{
    int leng = arr.Length;
    for(int i = 0; i < leng; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] PairsProdArray(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];
    
    for(int i = 0; i < size / 2; i++)
    {
        new_arr[i] = arr[i] * arr[size - 1 - i];
    }

    if(new_arr[flex_size - 1] == 0)
        new_arr[flex_size - 1] = arr[flex_size - 1];

    return new_arr;
}

int[] array = CreateArray();
Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine("Новый массив, составленый из произведений пар предыдущего массива:");
PrintArray(PairsProdArray(array));