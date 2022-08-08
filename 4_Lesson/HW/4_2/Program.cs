//Задача 2:
//Напишите программу,
//которая принимает на вход число
//и выдаёт сумму цифр в числе.

int NumSum(int Num)
{
    int Sum = 0;
    while(Num > 0)
    {
        Sum += Num % 10;
        Num /= 10;
    }
    return Sum;
}

Console.WriteLine("Введите целое число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе {num} равна {NumSum(num)}");