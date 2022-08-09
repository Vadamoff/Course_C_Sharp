//Задача 1:
//Задайте массив из 12 элементов,
//заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных
//и положительных элементов массива.

int[] CreateArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void ArrayPosNeg(int[] arr)
{
    int SumPos, SumNeg;
    SumPos = SumNeg = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
        SumNeg += arr[i];
        else
        SumPos += arr[i];
    }

    Console.WriteLine($"Сумма положительных элементов равна {SumPos}");
    Console.WriteLine($"Сумма отрицательных элементов равна {SumNeg}");
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

ArrayPosNeg(array);