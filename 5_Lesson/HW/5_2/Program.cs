//Задача 2:
//Задайте одномерный массив,
//заполненный случайными числами.
//Найдите сумму элементов,
//стоящих на нечётных позициях.

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
        arr[i] = new Random().Next(from, to + 1);
    
    return arr;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

void SumOddPosElements(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }

    Console.WriteLine($"Сумма элементов на нечётных позициях в массиве равна {sum}");
}

int[] array = CreateArray();

PrintArray(array);

SumOddPosElements(array);