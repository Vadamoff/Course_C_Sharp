//Задача 1:
//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray()
{
    Console.WriteLine("Введите количество чисел:");
    int num = int.Parse(Console.ReadLine());

    int[] arr = new int[num];
    
    for(int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите число:");
        arr[i] = int.Parse(Console.ReadLine());
    }
    
    return arr;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int SumPos(int[] arr)
{
    int sum = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            sum += 1;
    }

    return sum;
}

int[] array = CreateArray();

PrintArray(array);

Console.WriteLine($"Вы ввели {SumPos(array)} чисел больше 0");