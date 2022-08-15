//Задача 1:
//Напишите программу,
//которая перевернёт одномерный массив
//(последний элемент будет на первом месте,
//а первый - на последнем и т.д.)

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

int[] ReverseArray(int[] arr)
{
    int size = arr.Length - 1;

    for(int i = 0; i < size / 2 + 1; i++)
    {
        (arr[i], arr[size - i]) = (arr[size - i], arr[i]);
    }
    return arr;
}

int[] array = CreateArray();

PrintArray(array);

ReverseArray(array);

PrintArray(array);