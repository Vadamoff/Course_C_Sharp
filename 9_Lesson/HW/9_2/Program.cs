/*
Задача 2:
Задайте значения M и N.
Напишите программу,
которая найдёт сумму натуральных элементов
в промежутке от M до N с помощью рекурсии.
*/

int SumElement(int min, int max)
{
    if(min > max)
        return 0;
    return SumElement(min, max - 1) + max;
}

Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Сумма натуральных элементов от {M} до {N}:");
Console.WriteLine(SumElement(M, N));