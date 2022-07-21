//1. Напишите программу,
//которая принимает на входкоординаты точки (X и Y),
//причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
//в которой находится эта точка.

void Quarters(int x, int y)
{
    if(x == 0 || y == 0)
        Console.WriteLine("Точка находится на оси координат");
    else if(x > 0 && y > 0)
        Console.WriteLine("I");
    else if(x < 0 && y > 0)
        Console.WriteLine("II");
    else if(x < 0 && y < 0)
        Console.WriteLine("III");
    else if(x > 0 && y < 0)
        Console.WriteLine("IV");
}
Quarters(0, 9);
Quarters(2, 2);
Quarters(-3, 9);
Quarters(-4, -9);
Quarters(4, -9);