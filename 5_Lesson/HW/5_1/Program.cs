//Задача 1:
//Задайте массив заполненный
//случайными положительными трёхзначными числами.
//Напишите программу,
//которая покажет количество чётных чисел в массиве.

int[] CreateArray()
{
    Console.WriteLine("Задайте количество элементов в массиве:");
    int size = int.Parse(Console.ReadLine());
    
    int[] arr = new int[size];

    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 1000);
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

void CountEvenElements(int[] arr)
{
    int count = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
            count += 1;
    }

    if(count == 0)
        Console.WriteLine($"В массиве нет чётных чисел");
    else
        Console.WriteLine($"Чётных чисел в массиве: {count}");
}

int[] array = CreateArray();

PrintArray(array);

CountEvenElements(array);