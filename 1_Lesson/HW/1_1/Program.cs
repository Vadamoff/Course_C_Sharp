//2
//Напишите программу,
//которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

Console.WriteLine("Введите число:");
string a = Console.ReadLine();

Console.WriteLine("Введите ещё одно число:");
string b = Console.ReadLine();

int num_a = int.Parse(a);
int num_b = int.Parse(b);

if(num_a == num_b)
    {
        Console.WriteLine($"Числа равны");
    }
else if(num_a > num_b)
    {
        Console.WriteLine($"Число {num_a} - больше");
    }
else
    {
        Console.WriteLine($"Число {num_b} - больше");
    }