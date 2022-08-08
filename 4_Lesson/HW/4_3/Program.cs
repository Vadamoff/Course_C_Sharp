//Задача 3:
//Напишите программу,
//которая задаёт массив из 8 элементов случайными числами
//и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции.

void FillArray(int[] arr, int n)
{
    for(int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] arr)
{
    int leng = arr.Length;
    for(int i = 0; i < leng; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Введите целое число:");
int num = int.Parse(Console.ReadLine());

int[] array = new int[num];

FillArray(array, num);

Console.WriteLine($"Массив из {num} элементов:");
PrintArray(array);