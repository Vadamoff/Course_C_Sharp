//Задача 2:
//Задайте массив.
//Напишите программу,
//которая определяет,
//присутствует ли заданное число в массиве.

int[] CreateArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void FindElement(int[] arr)
{
    Console.WriteLine("Введите целое число:");
    int num = int.Parse(Console.ReadLine());

    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
            count += 1;
    }

    if(count == 0)
        Console.WriteLine($"Числа {num} нет в массиве");
    else
        Console.WriteLine($"Число {num} встречается в массиве {count} раз");
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

FindElement(array);

PrintArray(array);