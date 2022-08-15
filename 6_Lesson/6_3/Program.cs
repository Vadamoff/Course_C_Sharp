//Задача 2:
//Напишите программу,
//которая будет преобразовывать десятичное число в двоичное.

string DecToBin(int n)
{
    string result = "";
    while(n > 0)
        {
            result = (n % 2) + result;
            n /= 2;
        }
    return result;
}

Console.WriteLine("Введите целое число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} в десятичной системе равно {DecToBin(num)} в двоичной");