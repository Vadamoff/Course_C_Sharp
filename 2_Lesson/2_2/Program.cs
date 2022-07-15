//2. Напишите программу,
//которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшую цифру числа.

int MaxDigit(int MaxNum)
{
    if(MaxNum / 10 > MaxNum % 10)
    return MaxNum / 10;
    else
    return MaxNum % 10;
}

int Num = new Random().Next(10,100);

Console.WriteLine(Num);
Console.WriteLine(MaxDigit(Num));