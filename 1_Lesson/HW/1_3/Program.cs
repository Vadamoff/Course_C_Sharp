//6
//Напишите программу,
//которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
string a = Console.ReadLine();

int num = int.Parse(a);

if(num % 2 == 0)
    {
        Console.WriteLine($"Число {num} - чётное");
    }
else
    {
        Console.WriteLine($"Число {num} - нечётное");
    }