//8
//Напишите программу,
//которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
string n = Console.ReadLine();

int N = int.Parse(n);
int i = 2;

if(N > i)
{
    while(i <= N)
    {
        Console.WriteLine(i);
        i += 2;
    }
}