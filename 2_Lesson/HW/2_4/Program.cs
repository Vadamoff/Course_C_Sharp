//4
//Напишите программу,
//которая принимает на вход цифру,
//обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7:");
int d = int.Parse(Console.ReadLine());
if(d > 0 && d < 6)
    Console.WriteLine("Не является выходным, рабочий");
else if(d == 6 || d == 7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Введено неверное число");