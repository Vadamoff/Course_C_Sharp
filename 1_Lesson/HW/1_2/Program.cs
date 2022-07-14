//4
//Напишите программу,
//которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 1 число:");
string a = Console.ReadLine();

Console.WriteLine("Введите 2 число:");
string b = Console.ReadLine();

Console.WriteLine("Введите 3 число:");
string c = Console.ReadLine();

int num_a = int.Parse(a);
int num_b = int.Parse(b);
int num_c = int.Parse(c);
int large = num_a;

if(num_b > num_a)
    {
        large = num_b;
        if(num_c > num_b)
        {
            large = num_c;
        }
    }
else if(num_c > num_a)
    {
        large = num_c;
    }

Console.WriteLine($"Число {large} - самое большое");