//1. Напишите программу, которая на вход принимает два числа
//и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите первое число:");
string s_a = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string s_b = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if(a == b * b)
{
    Console.WriteLine($"{a} является квадратом {b}");
}
else
{
    Console.WriteLine($"{a} не является квадратом {b}");
}