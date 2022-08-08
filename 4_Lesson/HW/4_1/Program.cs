//Задача 1:
//Напишите цикл,
//который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

int Degree(int num, int deg)
{
    int result = 1;
    for(int i = 0; i < deg; i++)
    {
        result *= num;
    }
    return result;
}

Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"{A} в степени {B} равно {Degree(A, B)}");