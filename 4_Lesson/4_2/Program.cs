//Задача 1:
//Напишите программу,
//которая принимает на вход число
//и выдаёт количество цифр в числе.

void Length(int a)
{
    string num = a.ToString();
    Console.WriteLine(num.Length);
}

Length(1670);