/*
Задача 2:
Задайте значения M и N.
Напишите программу,
которая рекурсивно выведет все натуральные числа
в промежутке от M до N.
*/

void ValueSetMinMax(int min, int max)
{
    if(min > max)
        return;
    ValueSetMinMax(min, max - 1);
    Console.Write($"{max}, ");
}

Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Натуральные числа от {M} до {N}:");
ValueSetMinMax(M, N);