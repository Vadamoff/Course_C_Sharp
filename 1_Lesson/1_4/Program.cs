//5. Напишите программу,
//которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число:");
string a = Console.ReadLine();
int N = int.Parse(a);

int i = - N;

while(i <= N)
{
    Console.WriteLine(i);
    i++;
}