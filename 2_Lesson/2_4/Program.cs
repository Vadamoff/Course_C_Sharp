// 4. Напишите программу,
//которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23.

void Checking (int N)
{
    if (N % 7 == 0 && N % 23 == 0)
    Console.WriteLine("Yes");
    else
    Console.WriteLine("No");
}
Console.Write("Write a number N: ");
int n = int.Parse(Console.ReadLine());

Checking(n);