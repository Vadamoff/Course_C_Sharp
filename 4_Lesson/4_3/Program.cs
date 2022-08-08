//Задача 2:
//Напишите программу,
//которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.

int Factorial(int num)
{
    int AllSum = 1;
    for(int i = 1; i <= num; i++)
    {
        AllSum *= i;
    }
    return AllSum;
}

Console.WriteLine(Factorial(4));