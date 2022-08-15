﻿//Задача 1:
//Напишите программу,
//которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника:
//каждая сторона треугольника меньше суммы двух других сторон.

void Triangle(int a, int b, int c)
{
    if((a + b) > c && (b + c) > a && (c + a) > b)
        Console.WriteLine("Треугольник существует");
    else
        Console.WriteLine("Треугольник не существует");
}

Triangle(4, 2, 5);