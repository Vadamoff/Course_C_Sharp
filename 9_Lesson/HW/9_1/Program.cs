/*
Задача 1:
Задайте значения M и N.
Напишите программу,
которая выведет все чётные натуральные числа
в промежутке от M до N с помощью рекурсии.
*/

void ValueEvenMinMax(int min, int max)
{
    if(min > max)
        return;
    if(max % 2 != 0)
        max = max - 1;
    ValueEvenMinMax(min, max - 2);
    Console.Write($"{max}, ");
}

Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Чётные натуральные числа от {M} до {N}:");
ValueEvenMinMax(M, N);