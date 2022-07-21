//1
//Напишите программу,
//которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число:");
string n = Console.ReadLine();
    
int N = int.Parse(n);

int Remain = (N / 10) % 10;

Console.WriteLine(Remain);