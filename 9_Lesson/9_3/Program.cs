/*
Задача 3:
Напишите программу,
которая будет принимать на вход число
и возвращать сумму его цифр.
Использовать рекурсию.
*/

int SumDig(int n)
{
    if(n == 0)
        return 0;
    return SumDig(n / 10) + n % 10;
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Сумма цифр числа {num} равна:");
Console.WriteLine(SumDig(num));