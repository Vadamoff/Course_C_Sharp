/*
Задача 4:
Напишите программу,
которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
*/

int DegAB(int a, int b)
{
    if(b == 0)
        return 1;
    return DegAB(a, b - 1) * a;
}

Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"{A} в степени {B}:");
Console.WriteLine(DegAB(A, B));