//2
//Напишите программу,
//которая выводит случайное трёхзначное число
//и удаляет вторую цифру этого числа.

Random rand = new Random();
int n = rand.Next(100,1000);

Console.WriteLine(n);
Console.WriteLine(((n / 100) * 10) + (n % 10));